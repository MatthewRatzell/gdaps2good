using System;
using System.Collections.Generic;
using System.Text;

namespace MJR_OORefactoring
{
    class Player
    {
        private string playerName;
        private int playerScore;

        public Player(string playerName, Random rand)
        {
            this.playerName = playerName;
            this.playerScore = rand.Next(1,100);
        }

        public string PlayerName
        {
            get { return playerName; }
        }

        public int PlayerScore
        {
            get { return playerScore; }
        }
        public override string ToString()
        {
            return PlayerName + ", has a score of " + PlayerScore;
        }
    }
}
