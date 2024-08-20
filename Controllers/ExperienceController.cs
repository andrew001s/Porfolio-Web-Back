using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Models;
using PortfolioAPI.Services;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceServices _experienceServices;
        public ExperienceController(IExperienceServices experienceServices)
        {
            _experienceServices = experienceServices;
        }

        [HttpGet]
        public IEnumerable<Experience> GetExperience()
        {
            var experience = _experienceServices.GetExperience();
            IEnumerable<Experience> experienceList = 
                from exp in experience.Result
                
                orderby exp.Id descending
                select exp
                ;
            return experienceList;
        }

    }
}
