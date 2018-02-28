using ApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.Services
{
    public interface IPeopleRepository
    {
        IEnumerable<Person> People { get; }
    }
}
