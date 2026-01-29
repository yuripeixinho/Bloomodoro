using Bloomodoro.Application.Features.Progression.Plant.Dtos;
using Bloomodoro.Domain.Garden.PlantCatalog.Repositories;
using MediatR;

namespace Bloomodoro.Application.Features.Progression.Plant.Queries.ListPlants;

public class ListPlantHandler : IRequestHandler<ListPlantQuery, IReadOnlyList<PlantListDto>>
{
    private readonly IPlantSpeciesRepository _plantRepository;

    public ListPlantHandler(IPlantSpeciesRepository plantRepository)
    {
        _plantRepository = plantRepository; 
    }

    public async Task<IReadOnlyList<PlantListDto>> Handle(ListPlantQuery request, CancellationToken cancellationToken)
    {
        var plants = await _plantRepository.ListAsync(cancellationToken);

        var dto = plants
            .Select(p => new PlantListDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
            })
            .ToList();

        return dto;
    }
}
