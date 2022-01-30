using Pizzeria.Application.Interface;
using Pizzeria.Common.Interface;
using Pizzeria.Common.Model;
using Pizzeria.Repository.Interface;
using System;
using System.Collections.Generic;

namespace Pizzeria.Application.Application
{
    public class QueryApplication : IQueryApplication
    {

        private readonly IQuery _query;
        public QueryApplication(IQuery query)
        {
            this._query = query;
        }

        /// <summary>
        /// get All Crust
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Crust> GetAllCrust()
        {
            try
            {
                return _query.GetAllCrust();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// get All Sauce
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Sauce> GetAllSauce()
        {
            try
            {
                return _query.GetAllSauce();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// get All Cheese
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cheese> GetAllCheese()
        {
            try
            {
                return _query.GetAllCheese();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// get All Toppings
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Toppings> GetAllToppings()
        {
            try
            {
                return _query.GetAllToppings();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
