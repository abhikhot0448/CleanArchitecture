using MediatR;

namespace ActivityTracker.Application.Images.Commands.DeleteImages;

public record DeleteImageCommand(Guid ImageId) : IRequest<bool>;
