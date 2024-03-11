namespace BGT.Domain
{
    public interface IGames
    {
        Task Add(Game game);
        Task<IReadOnlyList<Game>> GetList();
    }
}