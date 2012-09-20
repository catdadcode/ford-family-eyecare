using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FordFamilyEyeCare.Domain.Repositories.Interfaces;
using FordFamilyEyeCare.Domain.Entities;

namespace FordFamilyEyeCare.Domain.Repositories.Objects
{
    public class VariableRepository : IVariableRepository
    {
        private EntityContainer _container;

        public VariableRepository(EntityContainer container)
        {
            this._container = container;
        }

        public Entities.Variable Get(string name)
        {
            return _container.Variables
                .SingleOrDefault(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }

        public bool Add(Variable variable)
        {
            bool exists = _container.Variables
                .Any(x => x.Name.Equals(variable.Name, StringComparison.InvariantCultureIgnoreCase));
            if (!exists)
                _container.Variables.AddObject(variable);
            return !exists;
        }

        public bool Delete(Variable variable)
        {
            bool exists = _container.Variables
                .Any(x => x.Name.Equals(variable.Name, StringComparison.InvariantCultureIgnoreCase));
            if (exists)
                _container.Variables.DeleteObject(variable);
            return exists;
        }

        public void SaveChanges()
        {
            _container.SaveChanges();
        }
    }
}
