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
        public QueryController(IQueryApplication queryApplication)
        {

            this._queryApplication = queryApplication;
        }      

        /// <summary>
        /// Get All Crust
        /// </summary>
        /// <returns>List of Crust</returns>
        [Route("query/getAllCrust")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult getAllCrust()
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

        /// <summary>
        /// Get All Crust
        /// </summary>
        /// <param name="employeeInput"></param>
        /// <returns>list of Sauces</returns>
        [Route("query/getAllSauce")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult getAllSauce()
        {
            try
            {
                var result = _queryApplication.GetAllSauce();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }


        /// <summary>
        /// Get All Cheese
        /// </summary>
        /// <returns>list of Cheese</returns>
        [Route("query/getAllCheese")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult getallCheese()
        {
            try
            {
                var result = _queryApplication.GetAllCheese();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Get All Toppings
        /// </summary>
        /// <returns>list of Toppings</returns>
        [Route("query/getAllToppings")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAllToppings()
        {
            try
            {
                var result = _queryApplication.GetAllToppings();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
    }
}
