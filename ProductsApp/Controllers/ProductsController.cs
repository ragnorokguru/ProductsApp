using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{ Id=1, Name="Tomato Soup", Category = "Groceries", Price = 1 },
            new Product{ Id=2, Name="Yo-Yo", Category = "Toys", Price = 3.75M },
            new Product{ Id=3, Name="Hammer", Category = "Hardware", Price = 16.99M },
        };

        // GET api/<controller>
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        [Route("api/products/{id}")]
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}