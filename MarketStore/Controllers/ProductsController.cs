using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MarketStore.Service;

namespace MarketStore.Controllers.Web
{
    [RoutePrefix("products")]
    public class ProductsController : ApiController
    {
        private readonly IProductService ProductService;

        public ProductsController(IProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProducts()
        {
            var result = await ProductService.GetProducts();

            if(result.Any())
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IHttpActionResult> GetProducts(int id)
        {
            var result = await ProductService.GetProducts();

            if (result.Any())
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IHttpActionResult> DeleteProduct(int id)
        {
            var result = await ProductService.GetProducts();

            if (result.Any())
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("update/{id}")]
        public async Task<IHttpActionResult> UpdateProduct(int id)
        {
            var result = await ProductService.GetProducts();

            if (result.Any())
            {
                return Ok(result);
            }

            return NotFound();
        }

    }
}
