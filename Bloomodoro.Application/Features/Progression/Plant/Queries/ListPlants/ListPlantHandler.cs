using Bloomodoro.Application.Common.Interfaces.Repositories;
using Bloomodoro.Application.Features.Progression.Plant.Dtos;
using MediatR;

namespace Bloomodoro.Application.Features.Progression.Plant.Queries.ListPlants;

public class ListPlantHandler : IRequestHandler<ListPlantQuery, IReadOnlyList<PlantListDto>>
{
    private readonly IPlantRepository _plantRepository;

    public ListPlantHandler(IPlantRepository plantRepository)
    {
        _plantRepository = plantRepository; 
    }

    public async Task<IReadOnlyList<PlantListDto>> Handle(ListPlantQuery request, CancellationToken cancellationToken)
    {
        var plants = await _plantRepository.ListAsync(cancellationToken);

        var dto = plants
            .Select(p => new PlantListDto
            {
                PlantId = p.PlantId,
                Name = p.Name,
                Description = p.Description,
            })
            .ToList();

        return dto;
    }
}
