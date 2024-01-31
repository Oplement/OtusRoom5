using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Core.Models;
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

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            await _productService.UpdateProductAsync(product);
            return Ok();
        }
        [HttpPost("updatePhoto")]
        public async Task<IActionResult> UpdatePhoto([FromBody] UpdatePhotoModel product)
        {
            await _productService.UpdateProductPhotoAsync(product.Id, product.Path);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Product product)
        {
            if (id != product.Id) return BadRequest();

            await _productService.UpdateProductAsync(product);
            return NoContent();
        }

        [HttpPost("delete", Name ="delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteProductModel model)
        {
            await _productService.DeleteProductAsync(model.ProductId);
            return NoContent();
        }
    }
}
