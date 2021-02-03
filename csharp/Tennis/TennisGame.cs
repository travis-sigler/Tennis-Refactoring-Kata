using System.Collections.Generic;

namespace Tennis
{
    class TennisGame : ITennisGame
    {
        private readonly PlayerModel Player1 = new PlayerModel();
        private readonly PlayerModel Player2 = new PlayerModel();
        private readonly Dictionary<int, string> scoreNames = new Dictionary<int, string>
        { 
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        /// <summary>
        /// Create a new tennis game with 2 players
        /// </summary>
        /// <param name="player1Name">Player 1 Name</param>
        /// <param name="player2Name">Player 2 Name</param>
        public TennisGame(string player1Name, string player2Name)
        {
            Player1.Name = player1Name;
            Player2.Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            Player1.Score += playerName == Player1.Name ? 1 : 0;
            Player2.Score += playerName == Player2.Name ? 1 : 0;
        }

        public string GetScore()
        {
            if (Player1.Score == Player2.Score)
            {
                return Player1.Score >= 3 ? "Deuce" : $"{scoreNames[Player1.Score]}-All";
            }

            if (Player1.Score >= 4 || Player2.Score >= 4)
            {
                var scoreDiff = Player1.Score - Player2.Score;

                if (scoreDiff == 1) return "Advantage player1";
                if (scoreDiff == -1) return "Advantage player2";
                if (scoreDiff >= 2) return "Win for player1"; 
                return "Win for player2";
            }

            return $"{scoreNames[Player1.Score]}-{scoreNames[Player2.Score]}";
        }
    }
}

