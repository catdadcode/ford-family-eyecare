using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeTunnel.MvcUtilities.Components;
using FordFamilyEyeCare.Web.ViewModels;
using FordFamilyEyeCare.Domain.Entities;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace FordFamilyEyeCare.Web.Controllers
{
    public class ContactUsController : AjaxHeaderPreservationController
    {
        private IContactInformationRepository _contactInfoRepo;

        public ContactUsController(IContactInformationRepository contactInfoRepo)
        {
            _contactInfoRepo = contactInfoRepo;
        }

        public ActionResult Index()
        {
            var viewModel = new ContactUsViewModel
            {
                Email = " FordFamilyEyeCare@att.net",
                PhoneNumber = "(208) 736-2020",
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Submit([Bind(Prefix = "ContactInformation")]ContactInformation contactInfo)
        {
            _contactInfoRepo.AddContactInfo(contactInfo);
            _contactInfoRepo.SaveChanges();
            var newEmail = new MailMessage("noreply@FordFamilyEyeCare.com", "fordfamilyeyecare@att.net");
            newEmail.Subject = "New appointment request.";
            newEmail.IsBodyHtml = true;
            newEmail.Body = System.IO.File.ReadAllText(Server.MapPath("~/content/emailtemplates/AppointmentRequest.htm"))
                .Replace("$LASTNAME", contactInfo.LastName)
                .Replace("$FIRSTNAME", contactInfo.FirstName)
                .Replace("$PHONE", contactInfo.PhoneNumber)
                .Replace("$EMAIL", contactInfo.Email)
                .Replace("$STREET", contactInfo.Street)
                .Replace("$CITY", contactInfo.City)
                .Replace("$STATE", contactInfo.State)
                .Replace("$ZIP", contactInfo.ZipCode.ToString())
                .Replace("$INSURANCEINFO", contactInfo.AdditionalInformation);
            var smtpServer = new SmtpClient("smtp.fordfamilyeyecare.com");
            smtpServer.Credentials = new NetworkCredential("noreply@fordfamilyeyecare.com", "duncanhines");
            smtpServer.Send(newEmail);
            ViewBag.Title = "Thank you!";
            ViewBag.Message = MvcHtmlString.Create("Thank you for your interest in Ford Family Eye Care!<br />A member of our staff will follow up with you within 2 business days.");
            return View("Message");
        }
    }
}
