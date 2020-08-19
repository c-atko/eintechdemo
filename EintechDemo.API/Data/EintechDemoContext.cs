using EintechDemo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EintechDemo.API.Data
{
    public class EintechDemoContext : IEintechDemoContext
    {
        private EintechDemoEntities _context;

        public EintechDemoContext()
        {
            _context = new EintechDemoEntities();
        }

        public IEnumerable<Person> GetPeople()
        {
            var query = from p in _context.Set<Person>()
                        select p;

            return query.AsEnumerable();
        }

        public void InsertPerson(string name)
        {
            var newPerson = new Person()
            {
                Name = name,
                CreatedDateTime = DateTime.Now
            };

            _context.Set<Person>().Add(newPerson);
            _context.SaveChanges();
        }
    }
}