using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Queries;

public record GetAllUserQuery(): IRequest<IEnumerable<User>>;
