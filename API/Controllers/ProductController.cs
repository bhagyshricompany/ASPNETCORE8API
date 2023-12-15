using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController: ControllerBase
    {
        private readonly StoreContext _context;
        public ProductController(StoreContext context)
        {
            this._context = context;
            
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>>GetProducts()
        {

           // var products = context.Products.ToList();
            return await _context.Products.ToListAsync();
           // return Ok(products);
        }
        [HttpGet("{id}")]
        public  async Task<ActionResult<Product>> GetProduct(int id)
        {
             return await _context.Products.FindAsync(id);
           // return Ok(product);
        }
    }
}