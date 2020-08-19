using EintechDemo.API.Models;
using System;
using System.Collections.Generic;

namespace EintechDemo.API.Repository
{
    public interface IPersonRepository
    {
        /// <summary>
        /// Get all Person records
        /// </summary>
        /// <returns>Enumerable List of <see cref="Person"></see>"/></returns>
        IEnumerable<Person> GetAll();

        /// <summary>
        /// Insert a Person record into the database
        /// </summary>
        void InsertPerson(string name);
    }
}
