using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisGame;

namespace TennisGameTests
{
    [TestClass]
    public class TennisGameTests
    {
        [TestMethod]
        public void Test_EarlyGame_Score_ShouldBe_Correct()
        {
            TennisGameScores game = new TennisGameScores();
            game.PlayGame(new int[] { 1, 2, 1 });
            Assert.AreEqual("thirty - fifteen", game.CalculateScore());
        }


        [TestMethod]
        public void Test_Advantage_Player1()
        {
            TennisGameScores game = new TennisGameScores();
            game.PlayGame(new int[] { 1, 1, 1, 2, 2, 2, 1 });
            Assert.AreEqual("advantage Player 1", game.CalculateScore());
        }

        [TestMethod]
        public void Test_Player1Wins()
        {
            TennisGameScores game = new TennisGameScores();
            game.PlayGame(new int[] { 1, 1, 1, 1 });
            Assert.AreEqual("Player 1 wins", game.CalculateScore());
        }

        [TestMethod]
        public void Test_Player2Wins_After_Deuce()
        {
            TennisGameScores game = new TennisGameScores();
            game.PlayGame(new int[] { 1, 2, 1, 2, 1, 2, 2, 2 });
            Assert.AreEqual("Player 2 wins", game.CalculateScore());
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Test_InvalidPlayerNumber()
        {
            TennisGameScores game = new TennisGameScores();
            game.PlayGame(new int[] { 3 }); // Invalid player number
        }
    }
}