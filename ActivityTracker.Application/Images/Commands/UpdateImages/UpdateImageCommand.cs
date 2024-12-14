using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Images.Commands.UpdateImages;

public record UpdateImageCommand(Image Image) : IRequest<Image>;
