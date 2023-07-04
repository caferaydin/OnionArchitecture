using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xProject.Application.Abstract.Repositoriy.ReadRepository;
using xProject.Application.Abstract.Repositoriy.WriteRepository;

namespace xProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _writeRepository;
        readonly private IProductReadRepository _readRepository;

        public ProductsController(IProductWriteRepository writeRepository, IProductReadRepository readRepository)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
        }

        [HttpGet("getAll")]
        public IActionResult Get()
        {
            IQueryable product =  _readRepository.GetAll();
            return Ok(product);
        }

        [HttpGet]
        public async Task GetAddProductRange()
        {
            await _writeRepository.AddRangeAsync(new(){
                new() {Id= Guid.NewGuid(), Name = "Product 1", Stock=10, Price=500,  CreatedAt= DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
                new() {Id= Guid.NewGuid(), Name = "Product 2", Stock=15, Price=600,  CreatedAt= DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
                new() {Id= Guid.NewGuid(), Name = "Product 3", Stock=20, Price=800,  CreatedAt= DateTime.UtcNow, UpdatedAt= DateTime.UtcNow }
            });
            await _writeRepository.SaveAsync();
        }
    }
}
