using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyCoffeeApp.Models;

namespace MyCoffee.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        public static List<Coffee> Coffee { get; } = new List<Coffee>();

        [HttpGet]
        public IEnumerable<Coffee> Get()
        {
            return Coffee;
        }

        [HttpGet("{id}")]
        public Coffee Get(int id)
        {
            return Coffee.FirstOrDefault(c => c.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Coffee value)
        {
            Coffee.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Coffee value)
        {
            var coffee = Coffee.FirstOrDefault(c => c.Id == id);
            if (coffee == null)
            {
                return;
            }

            coffee = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var coffee = Coffee.FirstOrDefault(c => c.Id == id);
            if (coffee == null)
            {
                return;
            }

            Coffee.Remove(coffee);
        }
    }
}
