using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Commands.AddEmployees;

public record AddUserCommand(User User) : IRequest<User>;

