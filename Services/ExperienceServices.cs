
using PortfolioAPI.Connections;
using PortfolioAPI.Models;

namespace PortfolioAPI.Services
{
    public class ExperienceServices : IExperienceServices
    {
        private readonly DBMySQLConnection _context;

        public ExperienceServices(DBMySQLConnection context)
        {
            _context = context;
        }
        public async Task<List<Experience>> GetExperience()
        {
            var experieces = _context.Experience.ToList();
            await Task.FromResult(experieces);
            return experieces;
        }
    }
}
