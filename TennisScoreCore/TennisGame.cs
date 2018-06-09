using System;

namespace TennisScoreCore
{
    public class TennisGame
    {
        private readonly IRepository<Game> _repo;

        public TennisGame(IRepository<Game> repo)
        {
            _repo = repo;
        }

        public string ScoreResult(int gameId)
        {
            var game = this._repo.GetGame(gameId);

            if (game.FirstPlayerScore == 0 && game.SecondPlayerScore == 0)
            {
                return "Love All";
            }

            if (game.FirstPlayerScore == 1 && game.SecondPlayerScore == 0)
            {
                return "Fifteen Love";
            }
            
            if (game.FirstPlayerScore == 2 && game.SecondPlayerScore == 0)
            {
                return "Fifteen Love";
            }
            
            if (game.FirstPlayerScore == 3 && game.SecondPlayerScore == 0)
            {
                return "Forty Love";
            }
            
            if (game.FirstPlayerScore == 0 && game.SecondPlayerScore == 1)
            {
                return "Love Fifteen";
            }
            
            if (game.FirstPlayerScore == 0 && game.SecondPlayerScore == 2)
            {
                return "Love Thirty";
            }

            if (game.FirstPlayerScore == 1 && game.SecondPlayerScore == 1)
            {
                return "Fifteen All";
            }
            
            if (game.FirstPlayerScore == 2 && game.SecondPlayerScore == 2)
            {
                return "Thirty All";
            }

            if (game.FirstPlayerScore == 3 && game.SecondPlayerScore == 3)
            {
                return "Deuce";
            }
            
            if (game.FirstPlayerScore == 4 && game.SecondPlayerScore == 3)
            {
                return "Joey Adv";
            }
            
            if (game.FirstPlayerScore == 3 && game.SecondPlayerScore == 4)
            {
                return "Tom Adv";
            }
            
            if (game.FirstPlayerScore == 4 && game.SecondPlayerScore == 4)
            {
                return "Deuce";
            }

            if (game.FirstPlayerScore == 5 && game.SecondPlayerScore == 3)
            {
                return "Joey Win";
            }

            return "";
        }
    }
}