using AutoMapper;
using Ecom.API.Helper;
using Ecom.Core.DTO;
using Ecom.Core.Entites.Product;
using Ecom.Core.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    public class ProductesController : BaseController
    {
        public ProductesController(IUnitOfWork work, IMapper mapper) : base(work, mapper)
        { }

        [HttpGet("get-all")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var products = await work.ProductRepositry
                    .GetAllAsync(x => x.Category, x => x.Photos);

                //  هنا بيحوّل الـ Entities اللي رجعت من الـ DB (نوعها Products) إلى قائمة من الـ DTO اللي إنت معرفه ProductDTO
                var result = mapper.Map<List<ProductDTO>>(products);

                if (products == null )
                {
                    return NotFound("No products found");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> getById(int id)
        {
            try
            {
                var product = await work.ProductRepositry.GetByIdAsync(id , x => x.Category, x => x.Photos);
                var result = mapper.Map<ProductDTO>(product);

                if (product == null)
                    return BadRequest(new ResponseAPI(400 ));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("add-product")]
        public async Task<IActionResult> add(AddProductDTO productDTO2)
        {
            try
            {
                await work.ProductRepositry.AddAsync(productDTO2);
                return Ok(new ResponseAPI(200, "Product added successfully"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut("update-product")]
        public async Task<IActionResult> update(UpdateProductDTO updateProductDTO)
        {
            try
            {
                await work.ProductRepositry.UpdateAsync(updateProductDTO);
                return Ok(new ResponseAPI(200, "Product updated successfully"));
            }
            catch (Exception ex)
            {
                return BadRequest( new ResponseAPI(400 , ex.Message));
            }
        }
        [HttpDelete("Delete-product/{id}")]
        public async Task<IActionResult> delete(int id)
        {
            try
            {
                var product = await work.ProductRepositry.GetByIdAsync(id,
                 x => x.Photos , x => x.Category);

                await work.ProductRepositry.DeleteAsync(product);
                return Ok(new ResponseAPI(200, "Product deleted successfully"));
            
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseAPI(400, ex.Message));
            }
        }

    }
}