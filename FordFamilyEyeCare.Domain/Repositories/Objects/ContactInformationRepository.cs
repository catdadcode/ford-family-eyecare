using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;
using FordFamilyEyeCare.Domain.Entities;

namespace FordFamilyEyeCare.Domain.Repositories.Objects
{
    public class ContactInformationRepository : IContactInformationRepository
    {
        private EntityContainer _entityContainer;

        public ContactInformationRepository(EntityContainer entityContainer)
        {
            _entityContainer = entityContainer;
        }

        public void AddContactInfo(ContactInformation contactInfo)
        {
            _entityContainer.ContactInformations.AddObject(contactInfo);
        }

        public void DeleteContactInfo(ContactInformation contactInfo)
        {
            _entityContainer.ContactInformations.DeleteObject(contactInfo);
        }

        public ContactInformation GetContactInfo(int id)
        {
            return _entityContainer.ContactInformations.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<ContactInformation> GetContacts()
        {
            return _entityContainer.ContactInformations;
        }

        public void SaveChanges()
        {
            _entityContainer.SaveChanges();
        }
    }
}
