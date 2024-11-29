using MediatR;

namespace ActivityTracker.Application.Users.Commands.DeleteUsers;

public record DeleteUserCommand(Guid userId):IRequest<bool>;

