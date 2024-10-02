using Business.Abstracts;
using Business.DTOs.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateProductRequest createProductRequest)
        {
            var result = await _productService.Add(createProductRequest);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _productService.GetListAsync();
            return Ok(result);
        }
    }
}
