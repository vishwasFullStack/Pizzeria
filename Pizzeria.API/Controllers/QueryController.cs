using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Application.Interface;
using Pizzeria.Common.Interface;
using Pizzeria.Common.Model;
using System;


namespace Pizzeria.API.Controllers
{
    public class QueryController : Controller
    {

        
        private readonly IQueryApplication _queryApplication;
        public QueryController(IOrderInput orderInput, IQueryApplication queryApplication)
        {

            this._queryApplication = queryApplication;
        }
      

        /// <summary>
        /// Get All Crust
        /// </summary>
        /// <param name="employeeInput"></param>
        /// <returns></returns>
        [Route("query/getAllCrust")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult orderPizza()
        {
            try
            {
                var result = _queryApplication.GetAllCrust();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
    }
}
