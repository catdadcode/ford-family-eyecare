using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;
using FordFamilyEyeCare.Domain.Repositories.Objects;
using FordFamilyEyeCare.Domain.Entities;

namespace FordFamilyEyeCare.Web.Ninject
{
    public class BindingsModule : NinjectModule
    {
        public override void Load()
        {
            #region Logic Classes

            #endregion

            #region Repositories
            
            this.Bind<IInsuranceRepository>().To<InsuranceRepository>();
            this.Bind<IVariableRepository>().To<VariableRepository>();
            this.Bind<IContactInformationRepository>().To<ContactInformationRepository>();
            
            #endregion

            #region Miscellanious

            #endregion
        }
    }
}