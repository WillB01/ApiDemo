using ApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.Services
{
    public interface IPeopleRepository
    {
        List<Person> People { get; }
        Person GetPersonById(int id);
        void Add(Person person);
    }
}
