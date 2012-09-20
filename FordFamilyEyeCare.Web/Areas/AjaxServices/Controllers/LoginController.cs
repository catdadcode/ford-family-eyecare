using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;
using System.Web.Security;

namespace FordFamilyEyeCare.Web.Areas.AjaxServices.Controllers
{
    public class LoginController : Controller
    {
        private IVariableRepository _variableRepository;

        public LoginController(IVariableRepository variableRepository)
        {
            _variableRepository = variableRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authenticate(string username, string password)
        {
            var masterUsername = _variableRepository.Get("MasterUsername").Value;
            var masterPassword = _variableRepository.Get("MasterPassword").Value;
            if (username.Equals(masterUsername, StringComparison.CurrentCultureIgnoreCase))
            {
                if (password == masterPassword)
                {
                    FormsAuthentication.SetAuthCookie(masterUsername, true);
                    return Json(new { Success = true });
                }
            }
            return Json(new { Success = false });
        }

        [Authorize]
        [HttpPost]
        public void Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}
