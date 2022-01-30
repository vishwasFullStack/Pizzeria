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

    }
}
