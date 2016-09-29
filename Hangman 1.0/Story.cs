using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hangman_1._0
{
    class Story
    {
        #region Class Variables

        private static string randomWord;
        private static int difficultyLevel;

        #endregion

        #region Properties

        public static string RandomWord
        {
            get { return randomWord; }
            set { randomWord = value; }
        }
        public static int DifficultyLevel
        {
            get { return difficultyLevel; }
            set { difficultyLevel = value; }
        }

        #endregion

        #region Story Methods

        public static void MainMenu(string playerName)  // Huvudmeny
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("\n\t    Hi " + playerName + "!");
                Console.WriteLine("\n      Welcome to Hangman 1.0\n");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("\t{   Main Menu:   }\n");
                Console.WriteLine("\t 1 - Play Game");
                Console.WriteLine("\t 2 - Tutorial");
                Console.WriteLine("\t 3 - Highscores\n");
                Console.WriteLine("----------------------------------");
                Console.Write("\tPick storyline: ");

                switch (choice = Console.ReadLine())
                {
                    case "1":
                        GameMenu(playerName);
                        break;
                    case "2":
                        break;
                    case "3":
                        ShowHighscore();
                        break;
                    default:
                        break;
                }
            } while (choice != "1");
        }
        public static void GameMenu(string playerName) //  Spelmeny
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("\n\t    Hi " + playerName + "!");
                Console.WriteLine("\n      Welcome to Hangman 1.0\n");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("\t{   Game Menu:   }\n");
                Console.WriteLine("\t 1 - Easy");
                Console.WriteLine("\t 2 - Medium");
                Console.WriteLine("\t 3 - Hard");
                Console.WriteLine("\t 4 - Main Menu\n");
                Console.WriteLine("----------------------------------");
                Console.Write("\tPick storyline: ");

                switch (choice = Console.ReadLine())
                {
                    case "1":
                        DifficultyLevel = 1;
                        Player.PlayerLife = 8;
                        RandomWord = DifficultyAndWord("Easy Words.txt");
                        break;
                    case "2":
                        DifficultyLevel = 2;
                        Player.PlayerLife = 6;
                        RandomWord = DifficultyAndWord("Medium Words.txt");
                        break;
                    case "3":
                        DifficultyLevel = 3;
                        Player.PlayerLife = 4;
                        RandomWord = DifficultyAndWord("Hard Words.txt");
                        break;
                    case "4":
                        MainMenu(playerName);
                        break;
                    default:
                        break;
                }
            } while (choice != "1" && choice != "2" && choice != "3" && choice != "4");
        }
        public static void ShowHighscore()  //  Skriver ut highscorelistan i konsolen
        {
            Highscore.HighScores = File.ReadAllLines(@"Highscore.txt");
            string[] highScoreNames = new string[Highscore.HighScores.Length];
            string[] highScorePoints = new string[Highscore.HighScores.Length];

            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n\t    Highscores:\n");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < Highscore.HighScores.Length; i++)
            {
                Highscore.SplitHighScores = Highscore.HighScores[i].Split(' ');
                highScoreNames[i] = Highscore.SplitHighScores[0];
                highScorePoints[i] = Highscore.SplitHighScores[1];
                Console.WriteLine("\t" + highScoreNames[i] + "\t\t" + highScorePoints[i]);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n      Press any key for menu\n");
            Console.WriteLine("----------------------------------");
            Console.ReadKey();
        }
        private static string DifficultyAndWord(string wordListPath)    //  Slumpar fram ett ord baserat på vald svårighetsgrad
        {
            Random rnd = new Random();
            string[] wordList;
            wordList = File.ReadAllLines(wordListPath);
            return wordList[rnd.Next(0, wordList.Length)];
        }

        #endregion
    }
}
