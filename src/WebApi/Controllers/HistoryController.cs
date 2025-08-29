using Application.GetGamesQuery;
using Application.GetMysteryNumberCommand;
using Application.GetPlayHistory;
using Application.PlayCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("history")]
    public class HistoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HistoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlayHistoryAsync(long id)
        {
            GetPlayHistoryQuery query = new(id);
            var commandSuccess = await _mediator.Send(query);
            return Ok(commandSuccess);
        }
    }
}
