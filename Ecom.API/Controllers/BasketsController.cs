using AutoMapper;
using Ecom.API.Helper;
using Ecom.Core.Entites;
using Ecom.Core.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    public class BasketsController : BaseController
    {
        public BasketsController(IUnitOfWork work, IMapper mapper) : base(work, mapper)
        {
        }


        [HttpGet("get-basket-item/{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var basket = await work.CustomerBasket.GetBasketAsync(id);
            if (basket is null)
            {
                return Ok(new CustomerBasket());
            }
            return Ok(basket);
        }


        [HttpPost("update-basket")]
        public async Task<IActionResult> Update([FromBody] CustomerBasket basket)
        {
            var _basket = await work.CustomerBasket.UpdateBasketAsync(basket);
            if (_basket == null) return BadRequest("Problem updating the basket");
            return Ok(_basket);
        } 


        [HttpDelete("delete-basket/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await work.CustomerBasket.DeleteBasketAsync(id);
            return result ? Ok( new ResponseAPI(200, "Basket deleted successfully")) 
                : BadRequest(new ResponseAPI(400, "Basket not found"));
        }

    }
}
