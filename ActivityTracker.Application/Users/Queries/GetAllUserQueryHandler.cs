using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Queries;
public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, IEnumerable<User>>
{
    #region Properties
    private readonly IUserRepository _userRepository;
    #endregion

    #region Constructor
    public GetAllUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    #endregion

    #region Methods
    public async Task<IEnumerable<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetUsersAsync();
    }
    #endregion

}
