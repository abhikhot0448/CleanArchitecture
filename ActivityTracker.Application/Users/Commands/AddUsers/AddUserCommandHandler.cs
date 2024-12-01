using ActivityTracker.Application.Users.Events;
using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Commands.AddEmployees
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, User>
    {
        #region Properties
        private readonly IUserRepository _userRepository;
        private readonly IMediator _mediator;
        #endregion

        #region Constructor
        public AddUserCommandHandler(IUserRepository userRepository, IMediator mediator)
        {
            _userRepository = userRepository;
            _mediator = mediator;
        }
        #endregion

        #region Methods
        public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
           var user = await _userRepository.AddUserAsync(request.User);
           await  _mediator.Publish(new UserCreatedEvent(request.User));
           return user;
        }
        #endregion
    }
}
