using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Events;

public record UserCreatedEvent(User user) : INotification;

