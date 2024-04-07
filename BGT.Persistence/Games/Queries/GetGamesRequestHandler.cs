using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BGT.Persistence.Games.Queries
{
    public class GetGamesRequestHandler : IRequestHandler<GetGamesRequest, GetGamesResponse>
    {
        private readonly ILogger<GetGamesRequestHandler> _logger;
        private readonly GamesContext _gamesContext;

        public GetGamesRequestHandler(
            ILogger<GetGamesRequestHandler> logger,
            GamesContext gamesContext)
        {
            _logger = logger;
            _gamesContext = gamesContext;
        }

        public async Task<GetGamesResponse> Handle(
            GetGamesRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _gamesContext.Games.ToListAsync(cancellationToken);

            return new GetGamesResponse
            {
                Games = response
            };
        }
    }
}
