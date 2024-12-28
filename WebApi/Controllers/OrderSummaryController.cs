using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Queries;

[Route("api/[controller]")]
[ApiController]
public class OrderSummaryController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderSummaryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("summary")]
    public async Task<IActionResult> GetSummary()
    {
        var result = await _mediator.Send(new GetSummaryQuery());
        return Ok(result);
    }
}
