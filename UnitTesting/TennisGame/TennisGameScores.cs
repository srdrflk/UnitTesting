using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame
{
    public class TennisGameScores
    {
        private int player1Points = 0;
        private int player2Points = 0;

        static void Main(string[] args)
        {
            TennisGameScores game = new TennisGameScores();
            int[] scores = { 1, 2, 1, 2, 1, 2, 2, 1, 1, 1 }; // Predetermined scores sequence
            game.PlayGame(scores);
        }

        public void PlayGame(int[] scores)
        {
            foreach (var player in scores)
            {
                if (player == 1)
                {
                    player1Points++;
                }
                else if (player == 2)
                {
                    player2Points++;
                }

                string score = CalculateScore();
                Console.WriteLine("Score: " + score);

                if (score.Contains("wins"))
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
            }
        }

        public string CalculateScore()
        {
            if ((player1Points >= 4 || player2Points >= 4) && Math.Abs(player1Points - player2Points) >= 2)
            {
                return player1Points > player2Points ? "Player 1 wins" : "Player 2 wins";
            }

            if (player1Points >= 3 && player2Points >= 3)
            {
                if (player1Points == player2Points)
                {
                    return "deuce";
                }
                if (Math.Abs(player1Points - player2Points) == 1)
                {
                    return player1Points > player2Points ? "advantage Player 1" : "advantage Player 2";
                }
            }

            return TranslateScore(player1Points) + " - " + TranslateScore(player2Points);
        }

        private string TranslateScore(int score)
        {
            switch (score)
            {
                case 0: return "love";
                case 1: return "fifteen";
                case 2: return "thirty";
                case 3: return "forty";
                default: return "";
            }
        }





        /*

        static void Main(string[] args)
        {
            TennisGameScores game = new TennisGameScores();
            int[] scores = { 1, 2, 1, 2, 1, 2, 2, 1, 1, 1 }; // Predetermined scores sequence
            game.PlayGame(scores);
        }

        public void PlayGame(int[] scores)
        {
            foreach (var player in scores)
            {
                if (player == 1)
                {
                    player1Points++;
                }
                else if (player == 2)
                {
                    player2Points++;
                }
                else
                {
                    Console.WriteLine("Invalid player number.");
                }

                string score = CalculateScore();
                Console.WriteLine("Score: " + score);

                if (score.Contains("wins"))
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
            }
        }

        public string CalculateScore()
        {
            if (player1Points >= 4 || player2Points >= 4)
            {
                var scoreDifference = Math.Abs(player1Points - player2Points);
                if (scoreDifference >= 2)
                {
                    return player1Points > player2Points ? "Player 1 wins" : "Player 2 wins";
                }
            }

            if (player1Points >= 3 && player2Points >= 3)
            {
                var scoreDifference = Math.Abs(player1Points - player2Points);
                if (player1Points == player2Points)
                {
                    return "deuce";
                }
                else if (scoreDifference == 1) // Explicit handling of advantage case
                {
                    return player1Points > player2Points ? "advantage Player 1" : "advantage Player 2";
                }
                //if (player1Points == player2Points)
                //{
                //    return "deuce";
                //}

                //return player1Points > player2Points ? "advantage Player 1" : "advantage Player 2";
            }

            return TranslateScore(player1Points) + " - " + TranslateScore(player2Points);
        }

        private string TranslateScore(int score)
        {
            switch (score)
            {
                case 0: return "love";
                case 1: return "fifteen";
                case 2: return "thirty";
                case 3: return "forty";
                default: return "";
            }
        }

        */
    }

}
