﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiDemo.Models;
using ApiDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IPeopleRepository _peopleRepositroy;

        public ValuesController(IPeopleRepository peopleRepositroy)
        {
            _peopleRepositroy = peopleRepositroy;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _peopleRepositroy.People;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
