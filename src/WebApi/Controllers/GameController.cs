using Application.GetGamesQuery;
using Application.GetMysteryNumberCommand;
using Application.GetPlayHistory;
using Application.PlayCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("game")]
    public class GameController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GameController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> PlayAsync(PlayCommand command)
        {
            var commandSuccess = await _mediator.Send(command);
            return Ok(commandSuccess);
        }

        [HttpGet]
        public async Task<IActionResult> GetGamesAsync()
        {
            GetGamesQuery query = new();
            var commandSuccess = await _mediator.Send(query);
            return Ok(commandSuccess);
        }

        [HttpGet("history/{id}")]
        public async Task<IActionResult> GetPlayHistoryAsync(long id)
        {
            GetPlayHistoryQuery query = new(id);
            var commandSuccess = await _mediator.Send(query);
            return Ok(commandSuccess);
        }

        [HttpGet("mystery-number")]
        public async Task<IActionResult> GetMysteryNumberAsync()
        {
            GetMysteryNumberCommand command = new();
            var commandSuccess = await _mediator.Send(command);
            return Ok(commandSuccess);
        }
    }
}
