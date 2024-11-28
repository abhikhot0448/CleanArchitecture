using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Queries;

public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
{
    #region Properties
    private readonly IUserRepository _userRepository;
    #endregion

    #region Constructor
    public GetUserByIdQueryHandler(IUserRepository userRepository) => _userRepository = userRepository;
    #endregion

    #region Methods
    public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetUserByIdAsync(request.userId);
    }
    #endregion

}
