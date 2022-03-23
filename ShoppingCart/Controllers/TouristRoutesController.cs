using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private ITouristRouteRepository _TouristRouteRepository;

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository)
        {
            _TouristRouteRepository = touristRouteRepository;
        }

        //public IActionResult GetTouristRoutes()
        //{

        //}
        [HttpGet]
        public IActionResult GetTouristRoutes()
        {
            var routes = _TouristRouteRepository.GetTouristRoutes();
            return Ok(routes);
        }

        //api/TouristRoutes/gTouristRoutesId
        [HttpGet("{gTouristRoutesId:Guid}")]
        public IActionResult GetTouristRouteById(Guid gTouristRoutesId)
        {
            return Ok(_TouristRouteRepository.GetTouristRoute(gTouristRoutesId));
        }
    }
}
