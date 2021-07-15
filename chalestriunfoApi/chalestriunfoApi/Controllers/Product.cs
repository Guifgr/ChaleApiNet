using System.Linq;
using chalestriunfoApi.Database;
using Microsoft.AspNetCore.Mvc;

namespace chalestriunfoApi.Controllers
{
    public class Product : Controller
    {
        public ChaleContext _Context;
        public Product(ChaleContext context)
        {
            _Context = context;
        }

        [HttpGet("GetChale/{id}")]
        public IActionResult getProduct([FromRoute] int id)
        {
            return Ok(_Context.product.First(c => c.Id == id));
        }
        
        [HttpGet("PostChale/{id}/{name}/{price}/{shortInformation}/{information}/{token}")]
        public IActionResult PostProduct(
            [FromRoute] string information,
            [FromRoute] decimal price,
            [FromRoute] string name,
            [FromRoute] string shortInformation,
            [FromRoute] int id,
            [FromRoute] string token
            )
        {
            if (token != TokenValid) return BadRequest();
            
            var product = _Context.product.First(c => c.Id == id);
            product.Information = information;
            product.Price = price;
            product.Name = name;
            product.ShortInformation = shortInformation;
            _Context.SaveChanges();
            return Ok(product);

        }

        private string TokenValid { get; set; } =
            "token";
    }
}