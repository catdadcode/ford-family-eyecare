using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;
using FordFamilyEyeCare.Web.ViewModels;

namespace FordFamilyEyeCare.Web.Controllers
{
    public class OfficeFormsController : Controller
    {
        private IVariableRepository _variableRepository;

        public OfficeFormsController(IVariableRepository variableRepository)
        {
            this._variableRepository = variableRepository;
        }

        public ActionResult Index(bool editMode = false)
        {
            var viewModel = new BasicContentViewModel
            {
                EditMode = User.Identity.IsAuthenticated && editMode,
                Content = MvcHtmlString.Create(_variableRepository.Get("OfficeFormsContent").Value)
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChangeContent(string content)
        {
            var variable = _variableRepository.Get("OfficeFormsContent");
            variable.Value = content;
            _variableRepository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
