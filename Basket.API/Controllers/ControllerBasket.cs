using Basket.API.Entities;
using Basket.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ControllerBasket : ControllerBase
    {
        private readonly IBasketRepository _repository;

        public ControllerBasket(IBasketRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<ShoppingCart>> GetBasket(string userName) 
        {
            var basket = await _repository.GetBasket(userName);

            return Ok(basket ?? new ShoppingCart(userName));
        }


        [HttpPost]
        public async Task<ActionResult<ShoppingCart>> UpdateBasket([FromBody] ShoppingCart basket) 
        {
            return Ok(await _repository.UpdateBasket(basket));        
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket(string userName) 
        {
            await _repository.DeleteBasket(userName);

            return Ok();
        }

    }
}
