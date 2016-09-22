using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class Player
    {
        private string playerName;

        public string GetPlayerInformation()
        {
            return playerName;
        }
        public void SetPlayerInformation(string input)
        {
            playerName = input;
        }
        public string AskForName()
        {
            string input;

            do
            {
                GFX.PlayerGFX();
                Console.Write("  Enter your name: ");
                input = Console.ReadLine();
            } while (input.Length < 3);

            return input;
        }
        
    }
}
