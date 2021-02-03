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
            Player1.Score += playerName == Player1.Name ? 1 : 0;
            Player2.Score += playerName == Player2.Name ? 1 : 0;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            
            // if tied, return tied values at each point
            //TODO - convert to more readable switch statement
            if (Player1.Score == Player2.Score)
            {
                score = Player1.Score switch
                {
                    0 => "Love-All",
                    1 => "Fifteen-All",
                    2 => "Thirty-All",
                    _ => "Deuce",
                };
            }

            // if either score is 4 or more, get the difference to determine score
            // TODO - convert to switch
            else if (Player1.Score >= 4 || Player2.Score >= 4)
            {
                var minusResult = Player1.Score - Player2.Score;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }

            // :( error :( error :( 
            // this is assigning each player their score name based on the score value (should not do this in a loop...)
            // TODO - this needs to be converted to assign a value to each individual player and load those values into a string
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

