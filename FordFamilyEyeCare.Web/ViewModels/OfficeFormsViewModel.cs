using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordFamilyEyeCare.Web.ViewModels
{
    public class OfficeFormsViewModel
    {
        public List<string> ExistingForms { get; set; }
        public bool EditMode { get; set; }
    }
}