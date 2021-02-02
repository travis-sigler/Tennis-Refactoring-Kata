namespace Tennis
{
    class TennisGame : ITennisGame
    {
        PlayerModel Player1 = new PlayerModel();
        PlayerModel Player2 = new PlayerModel();

        public TennisGame(string player1Name, string player2Name)
        {
            Player1.Name = player1Name;
            Player2.Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                Player1.Score += 1;
            else
                Player2.Score += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (Player1.Score == Player2.Score)
            {
                switch (Player1.Score)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
            }
            else if (Player1.Score >= 4 || Player2.Score >= 4)
            {
                var minusResult = Player1.Score - Player2.Score;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = Player1.Score;
                    else { score += "-"; tempScore = Player2.Score; }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}

