using MediatR;

namespace ActivityTracker.Application.Activities.Commands.DeleteActivities;

public record DeleteActivityCommand(Guid ActivityId) : IRequest<bool>;
