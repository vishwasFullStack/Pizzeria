using Pizzeria.Common.Model;
using System.Collections.Generic;

namespace Pizzeria.Application.Interface
{
    public interface IQueryApplication
    {
        IEnumerable<Crust> GetAllCrust();
    }
}