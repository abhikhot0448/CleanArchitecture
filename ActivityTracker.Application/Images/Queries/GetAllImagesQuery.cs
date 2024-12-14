using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Images.Queries;

public record GetAllImagesQuery() : IRequest<IEnumerable<Image>>;
