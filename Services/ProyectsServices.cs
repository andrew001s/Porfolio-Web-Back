using PortfolioAPI.Connections;
using PortfolioAPI.Models;

namespace PortfolioAPI.Services
{
    public class ProyectsServices : IProyectsServices
    {
        private readonly DBMySQLConnection _context;
        public ProyectsServices(DBMySQLConnection context)
        {
            _context = context;
        }
        public async Task<List<Proyects>> GetProyects()
        {
            var proyects = _context.Proyects.ToList();
            await Task.FromResult(proyects);
            return proyects;
        }
    }
}
