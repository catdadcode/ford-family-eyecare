using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FordFamilyEyeCare.Domain.Entities;

namespace FordFamilyEyeCare.Domain.Repositories.Interfaces
{
    public interface IContactInformationRepository
    {
        void AddContactInfo(ContactInformation contactInfo);
        void DeleteContactInfo(ContactInformation contactInfo);
        ContactInformation GetContactInfo(int id);
        IEnumerable<ContactInformation> GetContacts();
        void SaveChanges();
    }
}
