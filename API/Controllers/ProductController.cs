using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext context;

        public ProductController(StoreContext context)
        {
            this.context = context;
        }


        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await context.Products.ToListAsync();
            if (response != null)
            {
                
            return StatusCode(StatusCodes.Status200OK, response);
            }
            return StatusCode(StatusCodes.Status404NotFound, null);

        }

        [HttpPost]
        [Route("GetProductById/{Id:long}")]
        public async Task<IActionResult> GetProductById(long Id) {
            var response = await context.Products.FindAsync(Id);
            if (response != null)
            {
                
            return StatusCode(StatusCodes.Status200OK, response);
            }
            return StatusCode(StatusCodes.Status404NotFound, null);
            
        }
    }
}
