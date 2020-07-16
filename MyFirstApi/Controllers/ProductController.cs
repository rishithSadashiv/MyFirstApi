using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;
using MyFirstApi.Repositories;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductRepository repo = new ProductRepository();
        

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            List<Product> list = repo.GetAll();
            return Ok(list);
        }

        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            Product p = repo.Get(id);
            if (p != null)
                return Ok(p);
            else
                return Ok("No entry found");
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Post(Product p)
        {
            repo.Add(p);
            return Ok("Record Added");
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Put(Product p)
        {
            repo.Update(p);
            return Ok("Product updated");
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            return Ok("Product deleted");
        }
    }
}
