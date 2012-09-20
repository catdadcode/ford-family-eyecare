using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeTunnel.MvcUtilities.Components;

namespace FordFamilyEyeCare.Web.Areas.AjaxServices.Controllers
{
    /// <summary>
    /// Controller to handle AJAX requests related to the Contact Us page.
    /// </summary>
    public class ContactUsServiceController : AjaxHeaderPreservationController
    {
        /// <summary>
        /// Save the modified email address to the database.
        /// </summary>
        /// <param name="email">The new email address.</param>
        /// <returns>JSON object to notify client about the status of the request.</returns>
        public JsonResult SaveEmail(string email)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save the modified phone number to the database.
        /// </summary>
        /// <param name="phoneNumber">The new phone number.</param>
        /// <returns>JSON object to notify client about the status of the request.</returns>
        public JsonResult SavePhoneNumber(int phoneNumber)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save the modified address to the database.
        /// </summary>
        /// <param name="addressInformation">The new address information.</param>
        /// <returns>JSON object to notify client about the status of the request.</returns>
        public JsonResult SaveAddress(string addressInformation)
        {
            throw new NotImplementedException();
        }
    }
}
