using MediatR;

namespace BGT.Persistence.Games.Commands
{
    public class CreateGameRequest : IRequest<CreateGameResponse>
    {
        public string Name { get; set; } = null!;
    }
}
