using ActivityTracker.Application.Activities.Commands.AddActivities;
using ActivityTracker.Application.Activities.Commands.DeleteActivities;
using ActivityTracker.Application.Activities.Commands.UpdateActivities;
using ActivityTracker.Application.Activities.Queries;
using ActivityTracker.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActivityController : ControllerBase
{
    #region Properties
    private readonly IMediator _mediator;
    #endregion

    #region Constructor
    public ActivityController(IMediator mediator) => _mediator = mediator;
    #endregion

    #region Methods
    [HttpPost("activities")]
    public async Task<IActionResult> AddActivityAsync([FromBody] Activity activity)
    {
        activity.Id = Guid.NewGuid();
        var result = await _mediator.Send(new AddActivityCommand(activity));
        return Ok(result);
    }

    [HttpGet("activities")]
    public async Task<IActionResult> GetAllActivitiesAsync()
    {
        var result = await _mediator.Send(new GetAllActivitiesQuery());
        return Ok(result);
    }

    [HttpGet("activities/{activityId:guid}")]
    public async Task<IActionResult> GetActivityByIdAsync(Guid activityId)
    {
        var result = await _mediator.Send(new GetActivityByIdQuery(activityId));
        return Ok(result);
    }

    [HttpPut("activities")]
    public async Task<IActionResult> UpdateActivityAsync([FromBody] Activity activity)
    {
        var result = await _mediator.Send(new UpdateActivityCommand(activity));
        return Ok(result);
    }

    [HttpDelete("activities/{activityId:guid}")]
    public async Task<IActionResult> DeleteActivityAsync(Guid activityId)
    {
        var result = await _mediator.Send(new DeleteActivityCommand(activityId));
        return Ok(result);
    }
    #endregion
}
