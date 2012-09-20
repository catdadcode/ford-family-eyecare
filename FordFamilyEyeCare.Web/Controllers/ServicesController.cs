using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordFamilyEyeCare.Web.ViewModels;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;

namespace FordFamilyEyeCare.Web.Controllers
{
    public class ServicesController : Controller
    {
        private IVariableRepository _variableRepository;

        public ServicesController(IVariableRepository variableRepository)
        {
            this._variableRepository = variableRepository;
        }

        public ActionResult Index(bool editMode = false)
        {
            var viewModel = new BasicContentViewModel
            {
                EditMode = User.Identity.IsAuthenticated && editMode,
                Content = MvcHtmlString.Create(_variableRepository.Get("ServicesContent").Value)
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChangeContent(string content)
        {
            var variable = _variableRepository.Get("ServicesContent");
            variable.Value = content;
            _variableRepository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
