using BGT.Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BGT.Persistence.Games.Commands
{
    public class CreateGameRequestHandler : IRequestHandler<CreateGameRequest, CreateGameResponse>
    {
        private readonly ILogger<CreateGameRequest> _logger;
        private readonly GamesContext _gamesContext;

        public CreateGameRequestHandler(
            ILogger<CreateGameRequest> logger,
            GamesContext gamesContext)
        {
            _logger = logger;
            _gamesContext = gamesContext;
        }

        public async Task<CreateGameResponse> Handle(
            CreateGameRequest request,
            CancellationToken cancellationToken)
        {
            var newGame = new Game
            {
                Name = request.Name
            };

            await _gamesContext.Games.AddAsync(newGame, cancellationToken);

            return new CreateGameResponse { Id = newGame.Id };
        }
    }
}
