using ActivityTracker.Application.Images.Commands.AddImages;
using ActivityTracker.Application.Images.Commands.DeleteImages;
using ActivityTracker.Application.Images.Commands.UpdateImages;
using ActivityTracker.Application.Images.Queries;
using ActivityTracker.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImageController : ControllerBase
{
    #region Properties
    private readonly IMediator _mediator;
    #endregion

    #region Constructor
    public ImageController(IMediator mediator) => _mediator = mediator;
    #endregion

    #region Methods
    [HttpPost("images")]
    public async Task<IActionResult> AddImageAsync([FromBody] Image image)
    {
        image.Id = Guid.NewGuid();
        var result = await _mediator.Send(new AddImageCommand(image));
        return Ok(result);
    }

    [HttpGet("images")]
    public async Task<IActionResult> GetAllImagesAsync()
    {
        var result = await _mediator.Send(new GetAllImagesQuery());
        return Ok(result);
    }

    [HttpGet("images/{imageId:guid}")]
    public async Task<IActionResult> GetImageByIdAsync(Guid imageId)
    {
        var result = await _mediator.Send(new GetImageByIdQuery(imageId));
        return Ok(result);
    }

    [HttpPut("images")]
    public async Task<IActionResult> UpdateImageAsync([FromBody] Image image)
    {
        var result = await _mediator.Send(new UpdateImageCommand(image));
        return Ok(result);
    }

    [HttpDelete("images/{imageId:guid}")]
    public async Task<IActionResult> DeleteImageAsync(Guid imageId)
    {
        var result = await _mediator.Send(new DeleteImageCommand(imageId));
        return Ok(result);
    }
    #endregion
}
