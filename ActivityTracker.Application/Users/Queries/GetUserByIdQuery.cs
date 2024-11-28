using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Queries;

public record GetUserByIdQuery(Guid userId) : IRequest<User>;

