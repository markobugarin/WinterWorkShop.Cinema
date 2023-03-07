using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("projections")]
    public class ProjectionsController : BaseController
    {


        public readonly IProjectionsRepository _projectionsRepository;

        public ProjectionsController(IProjectionsRepository projectionsRepository)
        {
            _projectionsRepository = projectionsRepository;
        }

        [HttpGet()]
        public List<GetAllProjectionsResponse> GetProjections()
        {
            var projections = _projectionsRepository.GetAllProjections();

            var result = new List<GetAllProjectionsResponse>();

            foreach (var project in projections)
            {
                result.Add(new GetAllProjectionsResponse
                {
                    Id = project.Id,
                    brojSale = project.brojSale,
                    Date = project.Date
                });
            }

            return result;
        }
    }
}
