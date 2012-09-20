using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FordFamilyEyeCare.Domain.Entities;

namespace FordFamilyEyeCare.Domain.Repositories.Interfaces
{
    public interface IVariableRepository
    {
        /// <summary>
        /// Retrieves a variable from the database by its name.
        /// </summary>
        /// <param name="name">The name of the variable to retrieve.</param>
        /// <returns>A variable entity.</returns>
        Variable Get(string name);

        /// <summary>
        /// Creates a new variable in the database.
        /// </summary>
        /// <param name="variable">The variable to be added.</param>
        /// <returns>False if the variable exists already. True if the variable is successfully created.</returns>
        bool Add(Variable variable);

        /// <summary>
        /// Deletes an existing variable from the database.
        /// </summary>
        /// <param name="variable">The variable to be deleted.</param>
        /// <returns>False if the variable does not exist. True if the variable is deleted successfully.</returns>
        bool Delete(Variable variable);

        /// <summary>
        /// Persists changes to the database.
        /// </summary>
        void SaveChanges();
    }
}
