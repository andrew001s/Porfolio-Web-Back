using PortfolioAPI.Models;

namespace PortfolioAPI.Services
{
    public interface IExperienceServices
    {
        public Task<List<Experience>> GetExperience();
    }
}
