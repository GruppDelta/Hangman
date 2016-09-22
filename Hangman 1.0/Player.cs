using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class Player
    {
        private static string playerName;
        private static int playerLife;

        public static int PlayerLife
        {
            get { return playerLife; }
            set { playerLife = value;}
        }

        public static string PlayerName
        {
            get { return playerName; }
            set
            {
                if (value.Length > 3 || value.Length < 10)
                    playerName = value;
            }
        }
        public static void AskForName()

        {
            do
            {
                GFX.PlayerGFX();
                Console.Write("  Enter your name: ");
                PlayerName = Console.ReadLine();
            } while (PlayerName.Length < 3 || PlayerName.Length > 10);
        }
    }
}
