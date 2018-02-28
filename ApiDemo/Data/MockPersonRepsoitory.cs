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



        public List<Person> People => new List<Person>()
        {
            new Person(){Id = 1, FirstName = "Joe", LastName = "Awsome"},
            new Person(){Id = 2, FirstName = "Lisa", LastName = "Kewl"},
            new Person(){Id = 3, FirstName = "Bengt", LastName = "Wow"},
        };


        public void Add(Person person)
        {

            People.Add(person);
            
        }

        public Person GetPersonById(int id)
        {
            return People.FirstOrDefault(p => p.Id == id);
        }

        public List<string> GetPersonFirstName()
        {
            List<string> firstNames = new List<string>();
            foreach (var item in People)
            {
                firstNames.Add(item.FirstName);
            }
            return firstNames;
           
        }
    }
}
