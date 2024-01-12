using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common;
using Shop.Microservice.Infrastructure.Services;

namespace Shop.Microservice.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            var createdProduct = await _productService.CreateProductAsync(product);
            return CreatedAtAction(nameof(Get), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Product product)
        {
            if (id != product.Id) return BadRequest();

            await _productService.UpdateProductAsync(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _productService.DeleteProductAsync(id);
            return NoContent();
        }
    }
}
