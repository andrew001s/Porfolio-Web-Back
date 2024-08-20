using PortfolioAPI.Models;

namespace PortfolioAPI.Services
{
    public interface IProyectsServices
    {
        public Task<List<Proyects>> GetProyects();
    }
}
