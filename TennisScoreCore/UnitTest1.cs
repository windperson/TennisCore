using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TennisScoreCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Love_All()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 0, SecondPlayerScore = 0 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Love All", scoreResult);
        }
        
        [TestMethod]
        public void Fifteen_Love()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 1, SecondPlayerScore = 0 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Fifteen Love", scoreResult);
        }
        
        [TestMethod]
        public void Thirty_Love()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 2, SecondPlayerScore = 0 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Fifteen Love", scoreResult);
        }
        
        [TestMethod]
        public void Fourty_Love()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 3, SecondPlayerScore = 0 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Forty Love", scoreResult);
        }
        
        [TestMethod]
        public void Love_Fifteen()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 0, SecondPlayerScore = 1 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Love Fifteen", scoreResult);
        }
        
        [TestMethod]
        public void Love_Thirty()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 0, SecondPlayerScore = 2 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Love Thirty", scoreResult);
        }
        
        [TestMethod]
        public void Fifteen_All()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 1, SecondPlayerScore = 1 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Fifteen All", scoreResult);
        }
        
        [TestMethod]
        public void Thirty_All()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 2, SecondPlayerScore = 2 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Thirty All", scoreResult);
        }

        [TestMethod]
        public void Deuce()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 3, SecondPlayerScore = 3 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Deuce", scoreResult);
        }
        
        [TestMethod]
        public void Joey_Adv()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 4, SecondPlayerScore = 3 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Joey Adv", scoreResult);
        }
        
        [TestMethod]
        public void Tom_Adv()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 3, SecondPlayerScore = 4 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Tom Adv", scoreResult);
        }
        
        [TestMethod]
        public void Deuce_when4to4()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 4, SecondPlayerScore = 4 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Deuce", scoreResult);
        }

        [TestMethod]
        public void Joey_win()
        {
            var gameId = 1;

            IRepository<Game> repo = Substitute.For<IRepository<Game>>();
            repo.GetGame(gameId).Returns(new Game { Id = gameId, FirstPlayerScore = 5, SecondPlayerScore = 3 });

            TennisGame tennisGame = new TennisGame(repo);

            var scoreResult = tennisGame.ScoreResult(gameId);
            Assert.AreEqual("Joey Win", scoreResult);
        }

        
    }
}