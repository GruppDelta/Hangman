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
        }
        public void AskForName()
        {
            do
            {
                GFX.PlayerGFX();
                Console.Write("  Enter your name: ");
                playerName = Console.ReadLine();
            } while (playerName.Length < 3);
        }
    }
}
