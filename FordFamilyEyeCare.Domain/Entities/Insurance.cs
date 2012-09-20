using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FordFamilyEyeCare.Domain.Entities
{
    [Bind(Include="CompanyName, CompanyUrl, CompanyLogo")]
    [MetadataType(typeof(InsuranceMetadata))]
    public partial class Insurance
    {

    }

    public class InsuranceMetadata
    {
        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string CompanyUrl { get; set; }

        public string CompanyLogo { get; set; }
    }
}
