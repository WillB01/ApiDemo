using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiDemo.Models;
using ApiDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/People")]
    public class PeopleController : Controller
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleController(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        // GET: api/People
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _peopleRepository.People;
        }

        // GET: api/People/5
        [HttpGet("{id}", Name = "Get")]
        public Person Get(int id)
        {
            return _peopleRepository.GetPersonById(id);
        }

        [Route("GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            return _peopleRepository.GetPersonFirstName();
        }
        
        // POST: api/People
        [HttpPost]
        public void Post([FromBody]Person value)
        {
            _peopleRepository.Add(value);
        }
        
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
