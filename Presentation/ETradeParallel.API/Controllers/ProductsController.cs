using ETradeParallel.Application.Repositories;
using ETradeParallel.Application.RequestParameters;
using ETradeParallel.Application.Services;
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
        private readonly IFileService _fileService;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IFileService fileService)
        {
            this._productWriteRepository = productWriteRepository;
            this._productReadRepository = productReadRepository;
            this._fileService = fileService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] Paginator paginator)
        {
            var counts = _productReadRepository.GetAll(false).Count();
            var products = _productReadRepository.GetAll(false).Skip(paginator.Page * paginator.Size).Take(paginator.Size).Select(p => new
            {
                p.Id,
                p.Name,
                p.Price,
                p.Stock,
                p.CreatedDate,
                p.UpdatedDate
            });
            return Ok(new
            {
                products,
                counts,
            });
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
            await _productWriteRepository.AddAsync(new()
            {
                Name = model.Name,
                Stock = model.Stock,
                Price = model.Price,
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

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload()
        {
            await _fileService.UploadAsync("resource/product-images", Request.Form.Files);
            return Ok();
        }
    }

}