namespace Tennis
{
    public interface ITennisGame
    {
        /// <summary>
        /// Add a point to a player
        /// </summary>
        /// <param name="playerName">Player Name - must match added player</param>
        void WonPoint(string playerName);
        
        /// <summary>
        /// Determine the score
        /// </summary>
        /// <returns>Score as string</returns>
        string GetScore();
    }
}

