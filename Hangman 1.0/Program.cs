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
        static int playerLife;
        static string[] storyLine = new string[5];
        static string category;
        static Random rnd = new Random();
        static string randomWord;
        static bool isGameOver = false;
        static bool isProgramEnding = false;
        //static string usedLetters;
        //static string inputLetter;
        static string story;
        static string guessedWord = string.Empty;

        //Startar en sidotråd för musiken. Så programmet inte stannar upp. Behöver ligga i main.
        static Thread backgroundMusic = new Thread(new ThreadStart(MusicBeeper.MusicLoop));

        static void Main(string[] args)
        {
            Player.PlayerInformation();


            //Startar musiken. Måste ligga i samma scope som den där ^. Gärna main.
            //backgroundMusic.Start();


            while (!isProgramEnding)
            {
                StoryLine();
                GameLoop();
                GameEnd();
            }

            //Stänger av musiken. Mördar till och med tråden. Måste ligga i main
            //backgroundMusic.Abort();

            Console.ReadKey();
        }
        static void StoryLine()                 //  Presentation av storylines/svårighetsgrader
        {
            Console.Clear();
            Console.WriteLine("Hi " + Player.playerName + ", welcome to Hangman 1.0.\n");
            Console.WriteLine("Select difficulty:\n");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Hard");
            Console.WriteLine("4 - !!! DANGER ZONE !!!\n");
            Console.Write("Pick storyline: ");
            RandomWord(story = Console.ReadLine());
        }
        static void RandomWord(string choice)   //  Val av storyline
        {
            switch (story)
            {
                case "1":
                    randomWord = Easy();
                    break;
                case "2":
                    randomWord = Medium();
                    break;
                case "3":
                    randomWord = Hard();
                    break;
                case "4":
                    randomWord = DangerZone();
                    break;
                default:
                    StoryLine();
                    break;
            }
        }
        static string Easy()                    //  Svårighetsgrad; lätt
        {
            category = "Fruit";
            playerLife = 10;
            storyLine[0] = "BANAN";
            storyLine[1] = "ÄPPLE";
            storyLine[2] = "PÄRON";
            storyLine[3] = "KIWI";
            storyLine[4] = "APELSIN";

            return randomWord = storyLine[NumberGenerator()];
        }
        static string Medium()                  //  Svårighetsgrad; medel
        {
            category = "Fruit";
            playerLife = 8;
            storyLine[0] = "BANAN";
            storyLine[1] = "ÄPPLE";
            storyLine[2] = "PÄRON";
            storyLine[3] = "KIWI";
            storyLine[4] = "APELSIN";

            return randomWord = storyLine[NumberGenerator()];
        }
        static string Hard()                    //  Svårighetsgrad; svårt
        {
            category = "Fruit";
            playerLife = 6;
            storyLine[0] = "BANAN";
            storyLine[1] = "ÄPPLE";
            storyLine[2] = "PÄRON";
            storyLine[3] = "KIWI";
            storyLine[4] = "APELSIN";

            return randomWord = storyLine[NumberGenerator()];
        }
        static string DangerZone()              //  Svårighetsgrad; DANGER ZONE
        {
            category = "Fruit";
            playerLife = 2;
            storyLine[0] = "BANAN";
            storyLine[1] = "ÄPPLE";
            storyLine[2] = "PÄRON";
            storyLine[3] = "KIWI";
            storyLine[4] = "APELSIN";

            return randomWord = storyLine[NumberGenerator()];
        }
        static int NumberGenerator()            //  Nummergenerator
        {
            int randomNumber = rnd.Next(0, storyLine.Length - 1);
            return randomNumber;
        }
        static void GuessedWord()               //  Gissa ord
        {
            Console.WriteLine("You picked category: " + category);
            Console.WriteLine("The secret word has " + randomWord.Length + " letters.");
            Console.WriteLine("You have " + playerLife + " guesses left:");
            Console.Write("Guess word: ");
            guessedWord = Console.ReadLine().ToUpper();
        }
        static void GameLoop()                  //  Spelloop
        {
            while (!isGameOver)
            {
                Console.Clear();
                GuessedWord();
                WrongGuess();
                if (guessedWord == randomWord)
                {
                    isGameOver = true;
                    WinOrLose(true);
                }
                else if (playerLife < 1)
                {
                    isGameOver = true;
                    WinOrLose(false);
                }
                else
                {
                    Console.WriteLine(guessedWord + " is the wrong word,  please try again. :)");
                    Console.ReadKey();
                    isGameOver = false;
                }
            }
        }
        static void WrongGuess()                //  Räknar ner liv vid fel gissning
        {
            if (guessedWord != randomWord)
            {
                playerLife--;
            }
        }
        static void WinOrLose(bool win)         //  Vinst eller förlust?
        {
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
        static void GameEnd()                   //  Avsluta eller spela igen?
        {

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
