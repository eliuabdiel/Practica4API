using Microsoft.AspNetCore.Mvc;
using Practica4API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        // GET: api/<MarcasController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                testContext db = new testContext();

                //select * from productos
                List<Marcas> ListMarcas = db.Marcas.ToList();

                return Ok(ListMarcas);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        // GET api/<MarcasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MarcasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MarcasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MarcasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
