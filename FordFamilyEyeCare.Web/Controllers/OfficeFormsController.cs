using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;
using FordFamilyEyeCare.Web.ViewModels;
using System.IO;

namespace FordFamilyEyeCare.Web.Controllers
{
    public class OfficeFormsController : Controller
    {
        private const string FormDirectory = "~/content/officeforms/";

        public ActionResult Index(bool editMode = false)
        {
            try
            {
                var existingForms = Directory.GetFiles(Server.MapPath(FormDirectory))
                    .Select(x => Path.GetFileName(x))
                    .ToList();

                var viewModel = new OfficeFormsViewModel
                {
                    EditMode = editMode,
                    ExistingForms = existingForms
                };
                return View(viewModel);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        public ActionResult DeleteForm(string name)
        {
            System.IO.File.Delete(Path.Combine(Server.MapPath(FormDirectory), name));
            return RedirectToAction("Index", new { editMode = true });
        }

        public ActionResult UploadForm(HttpPostedFileBase newForm)
        {
            string path = Path.Combine(Server.MapPath(FormDirectory), Path.GetFileName(newForm.FileName));
            newForm.SaveAs(path);
            return RedirectToAction("Index", new { editMode = true });
        }
    }
}
