using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Commands.UpdateUsers;

public record UpdateUserCommand(User user):IRequest<User>;

