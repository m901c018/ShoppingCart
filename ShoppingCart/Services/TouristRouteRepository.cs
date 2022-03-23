using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class TouristRouteRepository : ITouristRouteRepository
    {
        public TouristRoute GetTouristRoute(Guid TouristRouteId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            throw new NotImplementedException();
        }
    }
}
