using Microsoft.AspNetCore.Mvc;
using BGT.Persistence.Games.Commands;
using BGT.Persistence.Games.Queries;
using MediatR;

namespace BGT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GamesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetGamesResponse))]
        public async Task<IActionResult> GetGames(
            [FromQuery] GetGamesRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreateGameResponse))]
        public async Task<IActionResult> AddGame(
            CreateGameRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);
        }
    }
}