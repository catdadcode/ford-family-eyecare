using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;
using FordFamilyEyeCare.Domain.Entities;
using CodeTunnel.MvcUtilities.Components;
using FordFamilyEyeCare.Web.ViewModels;
using System.Configuration;

namespace FordFamilyEyeCare.Web.Controllers
{
    public class HomeController : AjaxHeaderPreservationController
    {
        private IVariableRepository _variableRepository;

        public HomeController(IVariableRepository variableRepository)
        {
            this._variableRepository = variableRepository;
        }

        public ActionResult Index(bool editMode = false)
        {
            var content = "No Content.";
            try
            {
                content = _variableRepository.Get("HomeContent").Value;
            }
            catch (Exception ex)
            {
                content = ex.Message;
            }

            var viewModel = new BasicContentViewModel
            {
                EditMode = User.Identity.IsAuthenticated && editMode,
                Content = MvcHtmlString.Create(content)
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChangeContent(string content)
        {
            var variable = _variableRepository.Get("HomeContent");
            variable.Value = content;
            _variableRepository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
