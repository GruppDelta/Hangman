using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class Player
    {
        public static string playerName;
        public static void PlayerInformation()    
        {
            GFX.WelcomeGFX();
            do
            {
                GFX.PlayerGFX();
                Console.WriteLine("Please write your name: ");
                playerName = Console.ReadLine();
            } while (playerName.Length < 3);
        }
    }
}
