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
        private readonly ICommandApplication _orderApplication;
        public CommandController(IOrderInput orderInput, ICommandApplication orderApplication)
        {
            this._orderInput = orderInput;
            this._orderApplication = orderApplication;
        }
      

        /// <summary>
        /// Make Custom pizza
        /// </summary>
        /// <param name="employeeInput"></param>
        /// <returns></returns>
        [Route("Command/orderPizza")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult orderPizza([FromBody] OrderInput orderInput)
        {
            try
            {
                var result = _orderApplication.orderPizza(orderInput);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
    }
}
