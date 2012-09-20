using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FordFamilyEyeCare.Domain.Entities
{
    [MetadataType(typeof(ContactInformationMetaData))]
    public partial class ContactInformation : IValidatableObject
    {
        public IEnumerable<ValidationResult>  Validate(ValidationContext validationContext)
        {
 	        if (string.IsNullOrWhiteSpace(this.PhoneNumber) && string.IsNullOrWhiteSpace(this.Email))
                yield return new ValidationResult("You must include either a phone number or an email address.", new string[] { "PhoneNumber", "Email" });
        }
    }

    public class ContactInformationMetaData
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
