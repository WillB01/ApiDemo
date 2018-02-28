using ApiDemo.Models;
using ApiDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.Data
{
    public class MockPersonRepsoitory : IPeopleRepository
    {



        public IEnumerable<Person> People => new List<Person>()
        {
            new Person(){Id = 1, FirstName = "Joe", LastName = "Awsome"},
            new Person(){Id = 2, FirstName = "Lisa", LastName = "Kewl"},
        };

       
    }
}
