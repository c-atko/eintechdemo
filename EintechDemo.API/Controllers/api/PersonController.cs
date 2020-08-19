using EintechDemo.API.Data;
using EintechDemo.API.Models;
using EintechDemo.API.Repository;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace EintechDemo.API.Controllers
{
    public class PersonController : ApiController
    {
        private readonly IPersonRepository _personRepository;

        public PersonController()
        {
            _personRepository = new PersonRepository(new EintechDemoContext());
        }

        // GET: api/Person
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            try
            {
                return _personRepository.GetAll();
            }
            catch (Exception)
            {
                throw; // log, return friendly error message
            }
        }

        // POST: api/Person
        [HttpPost]
        public void Post([FromBody] string name)
        {
            try
            {
                _personRepository.InsertPerson(name);
            }
            catch (Exception)
            {
                throw; // log, return friendly error message
            }
        }
    }
}
