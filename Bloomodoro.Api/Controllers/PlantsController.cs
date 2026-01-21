using Bloomodoro.Application.Features.Progression.Plant.Queries.ListPlants;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bloomodoro.Api.Controllers
{
    //[Authorize]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class PlantsController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public PlantsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("plants")]
        public async Task<IActionResult> Get()
        {
            var query = new ListPlantQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
