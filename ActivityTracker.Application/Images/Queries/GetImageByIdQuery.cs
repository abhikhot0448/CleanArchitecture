using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Images.Queries;

public record GetImageByIdQuery(Guid ImageId) : IRequest<Image>;
