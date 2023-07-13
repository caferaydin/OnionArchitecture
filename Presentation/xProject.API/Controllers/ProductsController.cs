using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Net;
using xProject.Application.Abstract.Repositoriy.ReadRepository;
using xProject.Application.Abstract.Repositoriy.WriteRepository;
using xProject.Application.ViewModels.Products;
using xProject.Domain.Concrete;

namespace xProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _writeRepository;
        private readonly IProductReadRepository _readRepository;

        public ProductsController(IProductWriteRepository writeRepository, IProductReadRepository readRepository)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
            
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_readRepository.GetAll(false));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _readRepository.GetByIdAsync(id,false));
        }

        [HttpPost]
        public async Task<IActionResult> Add(VM_Create_Product product)
        {
            if(ModelState.IsValid)
            {

            }
            await _writeRepository.AddAsync(new()
            {
                Name = product.Name,
                Stock = product.Stock,
                Price = product.Price,

            });
            await _writeRepository.SaveAsync();
            return Ok(HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Update(VM_Update_Product updateProduct)
        {
            Product product = await _readRepository.GetByIdAsync(updateProduct.Id);
            product.Name = updateProduct.Name;
            product.Stock = updateProduct.Stock;
            product.Price = updateProduct.Price;
            
            await _writeRepository.SaveAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _writeRepository.DeleteAsync(id);
            await _writeRepository.SaveAsync();
            return Ok();
        }
    }
}
