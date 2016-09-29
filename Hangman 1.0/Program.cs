using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hangman_1._0
{
    class Program
    {
        //Startar en sidotråd för musiken. Så programmet inte stannar upp.
        static Thread backgroundMusic = new Thread(new ThreadStart(Beeper.MusicLoop));

        static void Main(string[] args)
        {
            Game.IsGameOver = false;

            GFX.WelcomeGFX();
            Player.PlayerInformation();
            //Startar musiken.
            backgroundMusic.Start();
            while (!Game.IsGameOver)
            {
                Story.MainMenu(Player.PlayerName);
                Game.GameLoop();
                Game.Restart();
            }
            //Stänger av musiken.
            backgroundMusic.Abort();
        }
    }
}

