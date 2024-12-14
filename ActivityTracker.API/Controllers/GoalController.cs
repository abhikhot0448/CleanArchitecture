using ActivityTracker.Application.Goals.Commands.AddGoals;
using ActivityTracker.Application.Goals.Commands.DeleteGoals;
using ActivityTracker.Application.Goals.Commands.UpdateGoals;
using ActivityTracker.Application.Goals.Queries;
using ActivityTracker.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GoalController : ControllerBase
{
    #region Properties
    private readonly IMediator _mediator;
    #endregion

    #region Constructor
    public GoalController(IMediator mediator) => _mediator = mediator;
    #endregion

    #region Methods
    [HttpPost("goals")]
    public async Task<IActionResult> AddGoalAsync([FromBody] Goal goal)
    {
        goal.Id = Guid.NewGuid();
        var result = await _mediator.Send(new AddGoalCommand(goal));
        return Ok(result);
    }

    [HttpGet("goals")]
    public async Task<IActionResult> GetAllGoalsAsync()
    {
        var result = await _mediator.Send(new GetAllGoalsQuery());
        return Ok(result);
    }

    [HttpGet("goals/{goalId:guid}")]
    public async Task<IActionResult> GetGoalByIdAsync(Guid goalId)
    {
        var result = await _mediator.Send(new GetGoalByIdQuery(goalId));
        return Ok(result);
    }

    [HttpPut("goals")]
    public async Task<IActionResult> UpdateGoalAsync([FromBody] Goal goal)
    {
        var result = await _mediator.Send(new UpdateGoalCommand(goal));
        return Ok(result);
    }

    [HttpDelete("goals/{goalId:guid}")]
    public async Task<IActionResult> DeleteGoalAsync(Guid goalId)
    {
        var result = await _mediator.Send(new DeleteGoalCommand(goalId));
        return Ok(result);
    }
    #endregion
}
