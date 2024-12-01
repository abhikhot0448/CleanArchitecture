using ActivityTracker.Application.Users.Commands.AddEmployees;
using ActivityTracker.Application.Users.Commands.DeleteUsers;
using ActivityTracker.Application.Users.Commands.UpdateUsers;
using ActivityTracker.Application.Users.Queries;
using ActivityTracker.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    #region Properties
    private readonly IMediator _mediator;
    #endregion

    #region Constructor
    public UserController(IMediator mediator) => _mediator = mediator;
    #endregion

    #region Methods

    [HttpPost("users")]
    public async Task<IActionResult> AddUserAsync([FromBody] User user)
    {
        user.Id = Guid.NewGuid();
        var result = await _mediator.Send(new AddUserCommand(user));
        return Ok(result);
    }

    [HttpGet("users")]
    public async Task<IActionResult> GetAllUserAsync()
    {
        var result = await _mediator.Send(new GetAllUserQuery());
        return Ok(result);
    }

    [HttpGet("users/{userId:guid}")]
    public async Task<IActionResult> GetUserByIdAsync(Guid userId)
    {
        var result = await _mediator.Send(new GetUserByIdQuery(userId));
        return Ok(result);
    }

    [HttpPut("users")]
    public async Task<IActionResult> UpdateUserAsync([FromBody] User user)
    {
        var result = await _mediator.Send(new UpdateUserCommand(user));
        return Ok(result);
    }

    [HttpDelete("users/{userId:guid}")]
    public async Task<IActionResult> DeleteUserAsync(Guid userId)
    {
        var result = await _mediator.Send(new DeleteUserCommand(userId));
        return Ok(result);
    }
    #endregion
}
