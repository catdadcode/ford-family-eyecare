$(function () {
    $.preLoadImages(
        "Content/images/buttonGradient.jpg",
        "Content/images/buttonHoverGradient.jpg"
    );

    $('textarea.editor').each(function () {
        var $editor = $(this);
        $editor.cleditor({ width: $editor.width(), height: $editor.height() });
    });

    $('.file_uploader').each(function () {
        var uploader = new qq.FileUploader(
        {
            element: this,
            action: $(this).attr('action'),
            showMessage: function (message) { alert(message); },
            onComplete: function (id, fileName, responseJSON) {
                //$('.qq-uploader').append("<div>Image Url: <input type='text' readonly='readonly' value='" + responseJSON.imageUrl + "' /></div><br />");
                var theimage = '<img style="max-width: 500px;" src="' + responseJSON.imageUrl + '" />';
                var currentval = $(".editor").val();
                $(".editor").val(currentval + theimage).cleditor()[0].updateFrame();
            }
        });
    });

    $.history.init(function (hash) {
        if (hash == "") {
            // initialize your app
        }
        else {
            var $loadedContent = $('#loadedContent');
            $loadedContent.fadeOut('fast', function () {
                $.ajax({
                    url: hash,
                    type: 'get',
                    success: function (response) {
                        $loadedContent.html(response).fadeIn('slow');
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        $loadedContent.html('');
                        var errorText = jqXHR.responseText.substring(jqXHR.responseText.indexOf('<body'));
                        $('<div></div>').css({
                            color: '#000',
                            backgroundColor: '#fff',
                            overflow: 'auto',
                            padding: '15px',
                            borderRadius: '15px'
                        })
                    .appendTo($loadedContent)
                    .html(errorText)
                    .fadeIn('fast');
                    }
                });
            });
        }
    }, { unescape: ",/" });

    var $navButtons = $('#navigation td.button');
    $navButtons.first().addClass('selected');
    $navButtons.each(function (i) {
        var $navButton = $(this);
        var navUrl = $(this).find('a').attr('href');
        if (navUrl) {
            $(this).click(function (e) {
                $navButtons.removeClass('selected');
                $navButton.addClass('selected');
                e.preventDefault();
                $.history.load(navUrl);
            });
        }
    });

    $('#login').click(function (e) {
        $.colorbox({
            href: '/AjaxServices/Login',
            onComplete: function () {
                $('#cboxClose').remove();
                $('#Password').keypress(function (e) {
                    var code = (e.keyCode ? e.keyCode : e.which);
                    if (code == 13)
                        $('#submitLogin').click();
                });
                $('#cancelLogin').click(function (e) {
                    $.colorbox.close();
                });
                $('#submitLogin').click(function (e) {
                    $.ajax({
                        url: '/AjaxServices/Login/Authenticate',
                        type: 'post',
                        data: { username: $('#Username').val(), password: $('#Password').val() },
                        success: function (response) {
                            if (response.Success)
                                window.location.reload(true);
                            else {
                                $('#failed').text('Wrong username or password.');
                                $.colorbox.resize();
                            }
                        }
                    });
                });
            }
        });
    });

    $('#logout').click(function (e) {
        $.ajax({
            url: '/AjaxServices/Login/Logout',
            type: 'post',
            success: function (response) {
                window.location.reload(true);
            }
        });
    });

    $('#banner').click(function (e) {
        $navButtons.removeClass('selected');
        $navButtons.first().addClass('selected');
        $.history.load('/');
    });
});


/* jQuery plugins */
(function ($) {
    var cache = [];
    // Arguments are image paths relative to the current page.
    $.preLoadImages = function () {
        var args_len = arguments.length;
        for (var i = args_len; i--; ) {
            var cacheImage = document.createElement('img');
            cacheImage.src = arguments[i];
            cache.push(cacheImage);
        }
    }

    $.fn.serializeObject = function()
    {
        var o = {};
        var a = this.serializeArray();
        $.each(a, function() {
            if (o[this.name] !== undefined) {
                if (!o[this.name].push) {
                    o[this.name] = [o[this.name]];
                }
                o[this.name].push(this.value || '');
            } else {
                o[this.name] = this.value || '';
            }
        });
        return o;
    };
})(jQuery)