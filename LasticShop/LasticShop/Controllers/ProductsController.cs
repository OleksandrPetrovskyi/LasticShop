using LasticShop.DatabaseModels;
using LasticShop.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LasticShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        ProductRepository _productRepository { get; set; }

        public ProductsController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(int count = 0)
        {
            var products = await _productRepository.GetProducts(count);

            if (products == null)
                return NotFound();

            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productRepository.GetProductById(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        //[HttpPost("{product: Product}")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            var newProductId = await _productRepository.CreateProduct(product);

            if (newProductId == 0)
                return NotFound();

            return Ok(newProductId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var productId = _productRepository.GetProductById(product.Id);

            if(productId == null)
                return NotFound();

            try
            {
                _productRepository.UpdateProduct(product);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }

            return Ok(product.Id);
        }

        [HttpDelete ("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = _productRepository.DeleteProduct(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}
