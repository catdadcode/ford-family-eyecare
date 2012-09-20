using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FordFamilyEyeCare.Domain.Entities;

namespace FordFamilyEyeCare.Web.ViewModels
{
    public class ContactUsViewModel
    {
        public ContactInformation ContactInformation { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressInformation { get; set; }
    }
}