using Final.Models;
using Final.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HepsiFlyApiController : ControllerBase
    {
        private readonly HepsiFlyServices _hepsiFlyServices;

        public HepsiFlyApiController(HepsiFlyServices hepsiFlyServices)
        {
            _hepsiFlyServices = hepsiFlyServices;
        }

        [HttpGet("GetCategory")]
        public ActionResult<List<Category>> GetCategory() =>
            _hepsiFlyServices.GetCategory();

        [HttpGet("GetProduct")]
        public ActionResult<List<Product>> GetProduct() =>
            _hepsiFlyServices.GetProduct();

        [HttpGet("GetCategoryById")]
        public ActionResult<Category> GetCategoryById(string id)
        {
            var category = _hepsiFlyServices.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        [HttpGet("GetProductById")]
        public ActionResult<Product> GetProductById(string id)
        {
            var product = _hepsiFlyServices.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost("CreateCategory")]
        public ActionResult<Category> CreateCategory(Category category)
        {
            _hepsiFlyServices.CreateCategory(category);
            return category;
            //return CreatedAtRoute("GetCategory", new { id = category.Id.ToString() }, category);
        }

        [HttpPost("CreateProduct")]
        public ActionResult<Product> CreateProduct(Product product)
        {

            _hepsiFlyServices.CreateProduct(product);
            return product;
            //return CreatedAtRoute("GetProduct", new { id = product.Id.ToString() }, product);
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory(string id, Category categoryIn)
        {
            var category = _hepsiFlyServices.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            _hepsiFlyServices.UpdateCategory(id, categoryIn);

            return NoContent();
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(string id, Product productIn)
        {
            var product = _hepsiFlyServices.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            _hepsiFlyServices.UpdateProduct(id, productIn);

            return NoContent();
        }

        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteCategory(string id)
        {
            var category = _hepsiFlyServices.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            _hepsiFlyServices.RemoveCategoryById(category.Id);

            return NoContent();
        }

        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct(string id)
        {
            var product = _hepsiFlyServices.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            _hepsiFlyServices.RemoveProductById(product.Id);

            return NoContent();
        }
    }
}
