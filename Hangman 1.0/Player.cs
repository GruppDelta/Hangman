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

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value;  }
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
