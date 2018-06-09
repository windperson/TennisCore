namespace TennisScoreCore
{
    public interface IRepository<T>
    {
        Game GetGame(int gameId);
    }
}