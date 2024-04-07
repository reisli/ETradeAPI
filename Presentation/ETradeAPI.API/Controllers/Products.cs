using ETradeAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETradeAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public Products(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }


        [HttpGet]
        public async void GetAll()
        {
            _productWriteRepository.AddRangeAsync(new()
            {
                new(){CreatedDate=DateTime.UtcNow,Id=Guid.NewGuid(),Name="Product 1",Price=100,Stock=200},
                new(){CreatedDate=DateTime.UtcNow,Id=Guid.NewGuid(),Name="Product 2",Price=200,Stock=300},
                new(){CreatedDate=DateTime.UtcNow,Id=Guid.NewGuid(),Name="Product 3",Price=300,Stock=400},
                new(){CreatedDate=DateTime.UtcNow,Id=Guid.NewGuid(),Name="Product 4",Price=400,Stock=500},
            });
           await _productWriteRepository.SaveAsync();
    
        }


    }
}
