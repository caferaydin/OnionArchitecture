using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using xProject.Application.Abstract.Repositoriy.ReadRepository;
using xProject.Application.Abstract.Repositoriy.WriteRepository;
using xProject.Domain.Concrete;

namespace xProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _writeRepository;
        private readonly IProductReadRepository _readRepository;

        public ProductsController(IProductWriteRepository writeRepository, IProductReadRepository readRepository, )
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
            
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            return Ok(_readRepository.GetAll());
        }
        public async Task<IActionResult> AddProduct(Product product)
        {
            return Ok(_writeRepository.AddAsync(product));
        }



    }
}
