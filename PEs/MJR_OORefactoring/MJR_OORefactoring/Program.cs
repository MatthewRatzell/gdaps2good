using System;

namespace MJR_OORefactoring
{
    class Program
    {
        static void Main(string[] args)
        {

            Random myRandom = new Random();
            Player[] playerArray = new Player[10];

            bool tryParse = false;
            int numberOfPlayers;
            // Find out how many players the user actually wants
            do
            {
                Console.Write("Enter number of players (up to 10): ");
                string numPlayersString = Console.ReadLine();
                tryParse = int.TryParse(numPlayersString, out numberOfPlayers);
                if (numberOfPlayers > 10)
                {
                    tryParse = false;
                }
            } while (tryParse == false);
            //basic sanatation and also creating our changingvariable
            Console.WriteLine();
            int playerNumber = 0;

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.Write("Enter player " + (playerNumber + 1) + "'s name: ");
                string playerName = Console.ReadLine();
                Player player = new Player(playerName, myRandom);
                playerArray[playerNumber] = player;
                playerNumber++;
            }

            Console.WriteLine();
            playerNumber = 0;
            // Print the player info
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Player " + (playerNumber + 1) + ", " + playerArray[i]);
                playerNumber++;
            }

            Console.WriteLine();
            //figuring out who the winner is

            //an int that holds the space in the array where the player with the highest score is
            int playerNumberWithHighestScore = 0;
            int highScore = 0;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                //sets current player score to the players score stored in this index of an arra7y
                int currentPlayerScore = playerArray[i].PlayerScore;
                //if the score of current index is higher it becomes the highsocre and it stores the index to be called later
                if(currentPlayerScore > highScore)
                {
                    highScore = currentPlayerScore;
                    playerNumberWithHighestScore = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The winner is " + (playerArray[playerNumberWithHighestScore].PlayerName));
        }
    }
}