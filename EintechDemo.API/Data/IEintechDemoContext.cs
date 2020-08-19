using EintechDemo.API.Models;
using System.Collections.Generic;

namespace EintechDemo.API.Data
{
    public interface IEintechDemoContext
    {
        IEnumerable<Person> GetPeople();

        void InsertPerson(string name);
    }
}
