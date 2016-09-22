using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class Story
    {
        private static string randomWord;
        private static string category;
        private static string[] storyLine = new string[5];
        private static Random rnd = new Random();

        public static string RandomWord
        {
            get { return randomWord; }
            set { randomWord = value; }
        }

        public static string Category
        {
            get { return category; }
            set { category = value; }
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
            Console.WriteLine("\t3 - Hard");
            Console.WriteLine("\t4 - DANGER ZONE\n");
            Console.WriteLine("----------------------------------");
            Console.Write("\tPick storyline: ");
            SetRandomWord(story = Console.ReadLine());
        }
        public static string SetRandomWord(string choice)   //  Val av storyline
        {
            switch (choice)
            {
                case "1":
                    return randomWord = Easy();
                case "2":
                    return randomWord = Medium();
                case "3":
                    return randomWord = Hard();
                case "4":
                    return randomWord = DangerZone();
                default:
                    return randomWord;

            }
        }
        public static string Easy()                    //  Svårighetsgrad; lätt
        {
            category = "Fruits and berries";
            Player.PlayerLife = 10;
            storyLine[0] = "BANAN";
            storyLine[1] = "ÄPPLE";
            storyLine[2] = "PÄRON";
            storyLine[3] = "DADEL";
            storyLine[4] = "MELON";

            return randomWord = storyLine[NumberGenerator()];
        }
        public static string Medium()                  //  Svårighetsgrad; medel
        {
            category = "Fruits and berries";
            Player.PlayerLife = 8;
            storyLine[0] = "BANAN";
            storyLine[1] = "ÄPPLE";
            storyLine[2] = "PÄRON";
            storyLine[3] = "DADEL";
            storyLine[4] = "MELON";

            return randomWord = storyLine[NumberGenerator()];
        }
        public static string Hard()                    //  Svårighetsgrad; svårt
        {
            category = "Fruits and berries";
            Player.PlayerLife = 6;
            storyLine[0] = "BANAN";
            storyLine[1] = "ÄPPLE";
            storyLine[2] = "PÄRON";
            storyLine[3] = "DADEL";
            storyLine[4] = "MELON";

            return randomWord = storyLine[NumberGenerator()];
        }
        public static string DangerZone()              //  Svårighetsgrad; DANGER ZONE
        {
            category = "Fruits and berries";
            Player.PlayerLife = 4;
            storyLine[0] = "BANAN";
            storyLine[1] = "ÄPPLE";
            storyLine[2] = "PÄRON";
            storyLine[3] = "DADEL";
            storyLine[4] = "MELON";

            return randomWord = storyLine[NumberGenerator()];
        }
        public static int NumberGenerator()            //  Nummergenerator
        {
            int randomNumber = rnd.Next(0, storyLine.Length - 1);
            return randomNumber;
        }
    }
}
