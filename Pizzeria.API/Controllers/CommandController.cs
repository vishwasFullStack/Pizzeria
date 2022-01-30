using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Application.Interface;
using Pizzeria.Common.Interface;
using Pizzeria.Common.Model;
using System;


namespace Pizzeria.API.Controllers
{
    public class CommandController : Controller
    {

        private readonly IOrderInput _orderInput;
        private readonly ICommandApplication _commandApplication;
        public CommandController(IOrderInput orderInput, ICommandApplication commandApplication)
        {
            this._orderInput = orderInput;
            this._commandApplication = commandApplication;
        }


        /// <summary>
        /// Order own pizza
        /// </summary>
        /// <param name="orderInput">order input</param>
        /// <returns>Order with detail</returns>
        [Route("command/orderPizza")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult orderPizza([FromBody] OrderInput orderInput)
        {
            try
            {
                var result = _commandApplication.orderPizza(orderInput);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
    }
}
