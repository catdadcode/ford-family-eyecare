using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FordFamilyEyeCare.Web.ViewModels
{
    public class BasicContentViewModel
    {
        public bool EditMode { get; set; }
        public MvcHtmlString Content { get; set; }
    }
}