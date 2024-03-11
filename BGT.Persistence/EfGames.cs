using BGT.Domain;

namespace BGT.Persistence
{
    public class EfGames : IGames
    {
        private readonly GamesContext _context;

        public EfGames(UnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }

            _context = unitOfWork.GamesContext;
        }

        public async Task Add(Game game)
        {
            if (game == null)
            {
                throw new ArgumentNullException(nameof(game));
            }

            await _context.Games.AddAsync(game);
        }

        public Task<IReadOnlyList<Game>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}