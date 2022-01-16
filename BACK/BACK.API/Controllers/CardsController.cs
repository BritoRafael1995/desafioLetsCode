using BACK.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BACK.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        // GET: Cards
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST Cards
        [HttpPost]
        public void Post([FromBody] Card card)
        {
        }

        // PUT Cards/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Card card)
        {
        }

        // DELETE Cards/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
