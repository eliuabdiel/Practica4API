using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica4API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                testContext db = new testContext();

                //select * from productos
                List<Products> ListProductos = db.Products.ToList();

                return Ok(ListProductos);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                testContext db = new testContext();

                //select * from productos where Id=N;
                Products producto =  db.Products.Where(a => a.Id == id).SingleOrDefault();

                return Ok(producto);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        // GET api/<ProductsController>/5
        [HttpGet("search/{name}", Name = "GetBusqueda")]
        public IActionResult GetBusqueda(string name)
        {
            try
            {
                if (name.Length < 3) return Ok();
                testContext db = new testContext();

                //select * from productos where Id=N;
                List<Products> productos = db.Products.Where(a => a.Nombre.Contains(name)).ToList();

                return Ok(productos);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
