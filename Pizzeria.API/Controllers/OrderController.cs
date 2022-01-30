using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Application.Interface;
using Pizzeria.Common.Interface;
using Pizzeria.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.API.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderInput _orderInput;
        private readonly IOrderApplication _orderApplication;
        public OrderController(IOrderInput orderInput, IOrderApplication orderApplication)
        {
            this._orderInput = orderInput;
            this._orderApplication = orderApplication;
        }
      

        /// <summary>
        /// Make Custom pizza
        /// </summary>
        /// <param name="employeeInput"></param>
        /// <returns></returns>
        [Route("orderPizza")]
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
