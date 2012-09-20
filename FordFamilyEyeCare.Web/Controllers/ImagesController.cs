using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace FordFamilyEyeCare.Web.Controllers
{
    public class ImagesController : Controller
    {
        [HttpPost]
        [Authorize]
        public JsonResult Upload(string qqfile)
        {
            var path = Server.MapPath("~/uploadedcontent/images/");
            var file = string.Empty;

            try
            {
                var stream = Request.InputStream;
                if (String.IsNullOrEmpty(Request["qqfile"]))
                {
                    HttpPostedFileBase postedFile = Request.Files[0];
                    stream = postedFile.InputStream;
                    file = Path.Combine(path, Path.GetFileName(Request.Files[0].FileName));
                }
                else
                {
                    file = Path.Combine(path, qqfile);
                }

                var buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                System.IO.File.WriteAllBytes(file, buffer);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }); 
            }

            return Json(new { success = true, imageUrl = Url.Content("~/uploadedcontent/images/" + qqfile) });
        }
    }
}
