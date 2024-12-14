using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Images.Commands.AddImages;

public record AddImageCommand(Image Image) : IRequest<Image>;
