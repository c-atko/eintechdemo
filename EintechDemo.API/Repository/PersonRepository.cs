using EintechDemo.API.Data;
using EintechDemo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EintechDemo.API.Repository
{
    public class PersonRepository : IPersonRepository, IDisposable
    {
        private readonly IEintechDemoContext _context;

        public PersonRepository(IEintechDemoContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.GetPeople();
        }

        public void InsertPerson(string name)
        {
            _context.InsertPerson(name);
        }

        public void Dispose()
        {
            
        }
    }
}