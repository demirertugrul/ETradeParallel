using ETradeParallel.Application.Repositories;
using ETradeParallel.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task GetProduct()
        {
            var p = await _productReadRepository.GetByIdAsync("5b93d84a-a20b-4bc5-adf2-60c3ea57e4c5",false);
            p.Stock = 50;
            await _productWriteRepository.SaveAsync();
        }
    }
}
