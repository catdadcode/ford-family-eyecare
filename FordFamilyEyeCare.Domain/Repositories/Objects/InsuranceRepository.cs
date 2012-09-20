using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;
using FordFamilyEyeCare.Domain.Entities;

namespace FordFamilyEyeCare.Domain.Repositories.Objects
{
    public class InsuranceRepository : IInsuranceRepository
    {
        EntityContainer _entityContainer = new EntityContainer();

        public IEnumerable<Entities.Insurance> GetInsurances()
        {
            return _entityContainer.Insurances.AsEnumerable<Insurance>();
        }

        public Insurance GetInsurance(long id)
        {
            return _entityContainer.Insurances.SingleOrDefault(x => x.Id == id);
        }


        public void AddInsurance(Insurance insurance)
        {
            _entityContainer.Insurances.AddObject(insurance);
        }

        public void SaveChanges()
        {
            _entityContainer.SaveChanges();
        }


        public void DeleteInsurance(long id)
        {
            _entityContainer.Insurances.DeleteObject(_entityContainer.Insurances.SingleOrDefault(x => x.Id == id));
        }
    }
}
