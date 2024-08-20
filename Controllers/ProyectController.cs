using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Models;
using PortfolioAPI.Services;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectController : ControllerBase
    {
        private readonly IProyectsServices _proyectsServices;
        public ProyectController(IProyectsServices proyectsServices)
        {
            _proyectsServices = proyectsServices;
        }

        public class PaginatedResult<T>
        {
            public IEnumerable<T> Items { get; set; }
            public int TotalPages { get; set; }
            public int CurrentPage { get; set; }
        }

        [HttpGet]
        public PaginatedResult<Proyects> GetProyects(int pageNumber = 1, int pageSize = 4)
        {
            var proyects = _proyectsServices.GetProyects().Result;
            int totalProyects = proyects.Count;
            int totalPages = (int)Math.Ceiling(totalProyects / (double)pageSize);
            var paginatedProyects = proyects
            .OrderByDescending(pr => pr.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);

            return new PaginatedResult<Proyects> { 
                Items = paginatedProyects,
                TotalPages = totalPages,
                CurrentPage = pageNumber
            };
        }


    }
}
