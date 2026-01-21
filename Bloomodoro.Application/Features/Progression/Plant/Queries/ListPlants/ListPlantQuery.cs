using Bloomodoro.Application.Features.Progression.Plant.Dtos;
using MediatR;

namespace Bloomodoro.Application.Features.Progression.Plant.Queries.ListPlants;

public record ListPlantQuery() : IRequest<IReadOnlyList<PlantListDto>>;
