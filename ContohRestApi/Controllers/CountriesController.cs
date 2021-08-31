using ContohRestApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContohRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private static List<Country> countries = new List<Country>()
        { 
            new Country(){ Id = 0, Name = "Indonesia", Language = "Indonesia"},
            new Country(){ Id = 1, Name = "England", Language = "Inggris"}
        };

        [HttpGet]
        public IEnumerable<Country> GET()
        {
            return countries;
        }

        [HttpPost]
        public void Post([FromBody] Country country)
        {
            countries.Add(country);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Country country)
        {
            countries[id] = country;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            countries.RemoveAt(id);
        }
    }
}
