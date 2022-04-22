using Eshop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id=1,
            Title = "Title 1",
            Description = "Description 1",
            ImageUrl = "ImageUrl1",
            Price = 9.99
        },
        new Product
        {
            Id=1,
            Title = "Title 2",
            Description = "Description 2",
            ImageUrl = "ImageUrl2",
            Price = 9.99
        },
        new Product
        {
            Id=1,
            Title = "Title 3",
            Description = "Description 3",
            ImageUrl = "ImageUrl3",
            Price = 9.99
        },
        new Product
        {
            Id=1,
            Title = "Title 4",
            Description = "Description 4",
            ImageUrl = "ImageUrl4",
            Price = 9.99
        }

    };

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(Products);
        }
    }
}
