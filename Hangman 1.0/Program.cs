using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class Program
    {
        static string playerName;
        static int playerLife;
        static string randomWord;
        //static string usedLetters;
        //static string inputLetter;
        static string story;
        static string guessedWord = string.Empty;
        static string jimmysKalsonger = "Svarta";
        static string name = "player";

        static void Main(string[] args)
        {
            WelcomeGFX();
            PlayerName();
            StoryLine();
            Console.ReadKey();
        }
        static void WelcomeGFX()
        {
            //  Välkomstgrafik
            Console.Clear();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║ ██████╗ ███████╗██╗  ████████╗ █████╗     ███████╗ ██████╗ ██╗   ██╗ █████╗ ██████╗ TM                             ║");
            Console.WriteLine(" ║ ██╔══██╗██╔════╝██║  ╚══██╔══╝██╔══██╗    ██╔════╝██╔═══██╗██║   ██║██╔══██╗██╔══██╗                               ║");
            Console.WriteLine(" ║ ██║  ██║█████╗  ██║     ██║   ███████║    ███████╗██║   ██║██║   ██║███████║██║  ██║                               ║");
            Console.WriteLine(" ║ ██║  ██║██╔══╝  ██║     ██║   ██╔══██║    ╚════██║██║▄▄ ██║██║   ██║██╔══██║██║  ██║                               ║");
            Console.WriteLine(" ║ ██████╔╝███████╗███████╗██║   ██║  ██║    ███████║╚██████╔╝╚██████╔╝██║  ██║██████╔╝                               ║");
            Console.WriteLine(" ║ ╚═════╝ ╚══════╝╚══════╝╚═╝   ╚═╝  ╚═╝    ╚══════╝ ╚══▀▀═╝  ╚═════╝ ╚═╝  ╚═╝╚═════╝                                ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║ ███████╗███╗   ██╗████████╗███████╗██████╗ ████████╗ █████╗ ██╗███╗   ██╗███╗   ███╗███████╗███╗   ██╗████████╗    ║");
            Console.WriteLine(" ║ ██╔════╝████╗  ██║╚══██╔══╝██╔════╝██╔══██╗╚══██╔══╝██╔══██╗██║████╗  ██║████╗ ████║██╔════╝████╗  ██║╚══██╔══╝    ║");
            Console.WriteLine(" ║ █████╗  ██╔██╗ ██║   ██║   █████╗  ██████╔╝   ██║   ███████║██║██╔██╗ ██║██╔████╔██║█████╗  ██╔██╗ ██║   ██║       ║");
            Console.WriteLine(" ║ ██╔══╝  ██║╚██╗██║   ██║   ██╔══╝  ██╔══██╗   ██║   ██╔══██║██║██║╚██╗██║██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║       ║");
            Console.WriteLine(" ║ ███████╗██║ ╚████║   ██║   ███████╗██║  ██║   ██║   ██║  ██║██║██║ ╚████║██║ ╚═╝ ██║███████╗██║ ╚████║   ██║       ║");
            Console.WriteLine(" ║ ╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝       ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║ ██████╗ ██████╗ ███████╗███████╗███████╗███╗   ██╗████████╗███████╗                                                ║");
            Console.WriteLine(" ║ ██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝████╗  ██║╚══██╔══╝██╔════╝                                                ║");
            Console.WriteLine(" ║ ██████╔╝██████╔╝█████╗  ███████╗█████╗  ██╔██╗ ██║   ██║   ███████╗                                                ║");
            Console.WriteLine(" ║ ██╔═══╝ ██╔══██╗██╔══╝  ╚════██║██╔══╝  ██║╚██╗██║   ██║   ╚════██║                                                ║");
            Console.WriteLine(" ║ ██║     ██║  ██║███████╗███████║███████╗██║ ╚████║   ██║   ███████║                                                ║");
            Console.WriteLine(" ║ ╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝                                                ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
        static void PlayerName()
        {
            //  Namninmatning
            Console.Clear();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                      ██░ ██  ▄▄▄       ███▄    █   ▄████  ███▄ ▄███▓ ▄▄▄       ███▄    █                           ║");
            Console.WriteLine(" ║                     ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓██▒▀█▀ ██▒▒████▄     ██ ▀█   █                           ║");
            Console.WriteLine(" ║                     ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▓██    ▓██░▒██  ▀█▄  ▓██  ▀█ ██▒                          ║");
            Console.WriteLine(" ║                     ░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒██    ▒██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒                          ║");
            Console.WriteLine(" ║                     ░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒▒██▒   ░██▒ ▓█   ▓██▒▒██░   ▓██░                          ║");
            Console.WriteLine(" ║                      ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░ ▒░   ░  ░ ▒▒   ▓▒█░░ ▒░   ▒ ▒                           ║");
            Console.WriteLine(" ║                     ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░ ░  ░      ░  ▒   ▒▒ ░░ ░░   ░ ▒░                           ║");
            Console.WriteLine(" ║                      ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░ ░      ░     ░   ▒      ░   ░ ░                           ║");
            Console.WriteLine(" ║                     ░  ░  ░      ░  ░         ░       ░        ░         ░  ░         ░                            ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                    ENTER THE NAME OF THE FOOLISH MORTAL WHO DARES ATTEMPT THIS GAME                                ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.Write("Name: ");
            playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hi " + playerName + ", welcome to Hangman 1.0.");
            Console.ReadKey();
        }
        static void StoryLine()
        {
            //  Storyline
            Console.Clear();
            Console.WriteLine("Select difficulty:\n");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Hard");
            Console.WriteLine("4 - Ultra hard\n");
            Console.Write("Pick storyline: ");
            story = Console.ReadLine();
            RandomWord();
        }
        static void RandomWord()
        {
            //  Ordgenerator
            switch (story)
            {
                case "1":
                    randomWord = "banan";
                    playerLife = 10;
                    break;
                case "2":
                    randomWord = "äpple";
                    playerLife = 8;
                    break;
                case "3":
                    randomWord = "kiwi";
                    playerLife = 6;
                    break;
                case "4":
                    randomWord = "bappelsin";
                    playerLife = 4;
                    break;
                default:
                    StoryLine();
                    break;
            }
            GameLoop();
        }
        static void GuessedWord()
        {
            Console.Write("Gissa ord: ");
            guessedWord = Console.ReadLine().ToLower();
        }
        static void GameLoop()
        {
            //  Spelloop
            Console.Clear();
            GuessedWord();

            if (guessedWord == randomWord && playerLife > 0)
            {
                WinOrLose(true);
            }
            else if (guessedWord != randomWord && playerLife > 0)
            {
                Console.WriteLine("Wrong word!");
                playerLife--;
                Console.WriteLine("Player life: " + playerLife);
                Console.ReadKey();
                GameLoop();
            }
            else
            {
                WinOrLose(false);
            }
        }
        static void WinOrLose(bool win)
        {
            //  Vinst eller förlust
            if (win == true)
            {
                Console.Clear();
                Console.WriteLine("You win!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You lose!");
                Console.ReadKey();
            }
            GameEnd();
        }
        static void GameEnd()
        {
            //  Programavslut
            Console.Write("Play again? (Y/N)");
            string again = Console.ReadLine();
            again = again.ToUpper();

            switch (again)
            {
                case "Y":
                    StoryLine();
                    break;
                case "N":
                    Console.Clear();
                    Console.WriteLine("Thanks for playing! /h@xx");
                    break;
                default:
                    GameEnd();
                    break;
            }
        }
    }
}
