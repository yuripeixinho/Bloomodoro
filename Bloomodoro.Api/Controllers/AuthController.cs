using Bloomodoro.Application.Features.Auth.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bloomodoro.Api.Controllers;

public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthController(IMediator mediator)
    {
        _mediator = mediator;   
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login([FromBody] LoginCommand command)
    {
        try
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return Unauthorized(ex.Message);
        }
    }

    [HttpPost("register")]
    public async Task<ActionResult> Register([FromBody] RegisterCommand command)
    {
        try
        {
            var response = await _mediator.Send(command);
            return CreatedAtAction(nameof(Register), new { id = response });
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
