using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FordFamilyEyeCare.Domain.Entities;

namespace FordFamilyEyeCare.Domain.Repositories.Interfaces
{
    public interface IInsuranceRepository
    {
        IEnumerable<Insurance> GetInsurances();
        void AddInsurance(Insurance insurance);
        void DeleteInsurance(long id);
        Insurance GetInsurance(long id);
        void SaveChanges();
    }
}
