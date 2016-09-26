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
        private static string randomWord;
        private static int difficultyLevel;

        public static string RandomWord
        {
            get { return randomWord; }
            set { randomWord = value; }
        }

        public static int DifficultyLevel
        {
            get; set;
        }

        public static void StoryLine(string playerName) //  Storyline
        {

            string story;
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n\t    Hi " + playerName + "!");
            Console.WriteLine("\n      Welcome to Hangman 1.0\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\tSelect difficulty:\n");
            Console.WriteLine("\t1 - Easy");
            Console.WriteLine("\t2 - Medium");
            Console.WriteLine("\t3 - Hard\n");
            Console.WriteLine("----------------------------------");
            Console.Write("\tPick storyline: ");
            RandomWord = SetRandomWord(story = Console.ReadLine()).ToUpper();
        }
        public static string SetRandomWord(string choice)   //  Val av storyline
        {
            do
            {
                switch (choice)
                {
                    case "1":
                        DifficultyLevel = 1;
                        Player.PlayerLife = 10;
                        return DifficultyAndWord("Easy Words.txt");
                    case "2":
                        DifficultyLevel = 2;
                        Player.PlayerLife = 8;
                        return DifficultyAndWord("Medium Words.txt");
                    case "3":
                        DifficultyLevel = 3;
                        Player.PlayerLife = 5;
                        return DifficultyAndWord("Hard Words.txt");
                    default:
                        break;
                }
                choice = Console.ReadLine();
            } while (true);

        }

        private static string DifficultyAndWord(string wordListPath)
        {
            Random rnd = new Random();
            string[] wordList;
            wordList = File.ReadAllLines(@"Word Lists\" + wordListPath);
            return wordList[rnd.Next(0, wordList.Length)];
        }
    }
}
