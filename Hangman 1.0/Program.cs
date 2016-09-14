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
        static bool isGameOver = false;
        static bool isProgramEnding = false;
        //static string usedLetters;
        //static string inputLetter;
        static string story;
        static string guessedWord = string.Empty;

        static void Main(string[] args)
        {
            WelcomeGFX();
            PlayerName();
            while (!isProgramEnding)
            {
                StoryLine();
                RandomWord();
                GameLoop();
                GameEnd();
            }
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
            do
            {
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
            }
            while (playerName.Length < 3);
        }
        static void StoryLine()
        {
            //  Storyline
            Console.Clear();
            Console.WriteLine("Hi " + playerName + ", welcome to Hangman 1.0.\n");
            Console.WriteLine("Select difficulty:\n");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Hard");
            Console.WriteLine("4 - !!! DANGER ZONE !!!\n");
            Console.Write("Pick storyline: ");
            story = Console.ReadLine();
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
        }
        static void GuessedWord()
        {
            Console.Write("Guess word: ");
            guessedWord = Console.ReadLine().ToLower();
        }
        static void GameLoop()
        {
            //  Spelloop
            Console.Clear();

            while (!isGameOver)
            {
                Console.WriteLine("Player life: " + playerLife);
                GuessedWord();
                WrongGuess();
                if (guessedWord == randomWord || playerLife < 1)
                {
                    isGameOver = true;
                }
            }
            if (guessedWord == randomWord)
            {
                WinOrLose(true);
            }
            else
            {
                WinOrLose(false);
            }
        }

        static void WrongGuess()
        {
            if (guessedWord != randomWord)
            {
                playerLife--;
            }
        }
        static void WinOrLose(bool win)
        {
            //  Vinst eller förlust
            Console.Clear();
            if (win == true)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            Console.ReadKey();
        }
        static void GameEnd()
        {
            //  Programavslut

            Console.Write("Play again? (Y/N)");
            string again = Console.ReadLine().ToUpper();

            switch (again)
            {
                case "Y":
                    isGameOver = false;
                    break;
                case "N":
                    Console.Clear();
                    Console.WriteLine("Thanks for playing! /h@xx");
                    isProgramEnding = true;
                    break;
                default:
                    GameEnd();
                    break;
            }
        }
    }
}
