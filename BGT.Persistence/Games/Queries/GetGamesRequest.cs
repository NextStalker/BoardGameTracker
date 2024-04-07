using BGT.Domain;

namespace BGT.Persistence.Games.Queries
{
    public class GetGamesResponse
    {
        public ICollection<Game> Games { get; set; } = null!;
    }
}
