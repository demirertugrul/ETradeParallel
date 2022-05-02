using ETradeParallel.Application.Repositories;
using ETradeParallel.Application.ViewModel.Products;
using ETradeParallel.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ETradeParallel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            this._productWriteRepository = productWriteRepository;
            this._productReadRepository = productReadRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _productReadRepository.GetAll(false);
            return Ok(products);
        }
        [HttpPut]
        public async Task<IActionResult> Put(VM_Updated_Product model)
        {
            Product product = await _productReadRepository.GetByIdAsync(model.id);
            product.Name = model.Name;
            product.Stock = model.Stock;
            product.Price = model.Price;
            await _productWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.OK);
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Created_Product model)
        {
            if (ModelState.IsValid)
            {

            }
            await _productWriteRepository.AddAsync(new()
            {
                Name=   model.Name,
                Stock= model.Stock,
                Price= model.Price,
            });
            await _productWriteRepository.SaveAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productWriteRepository.RemoveByIdAsync(id);
            await _productWriteRepository.SaveAsync();
            return Ok();
        }
    }

}