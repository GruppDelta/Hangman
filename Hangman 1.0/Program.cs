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

        static Player player = new Player();
        public static bool isGameOver;
        
        static void Main(string[] args)
        {
            isGameOver = false;

            GFX.WelcomeGFX();
            player.SetPlayerInformation(player.AskForName());
            //Startar musiken.
            backgroundMusic.Start();
            while (!isGameOver)
            {
                Story.StoryLine(player.GetPlayerInformation());
                Game.GameLoop();
                Game.Restart();
            }
            //Stänger av musiken.
            backgroundMusic.Abort();
        }
    }
}

