using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class Story
    {
        public static string randomWord;
        public static string category;
        public static int playerLife;
        public static string[] storyLine = new string[5];
        public static Random rnd = new Random();

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
            RandomWord(story = Console.ReadLine());
        }
        public static string RandomWord(string choice)   //  Val av storyline
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
            playerLife = 10;
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
            playerLife = 8;
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
            playerLife = 6;
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
            playerLife = 4;
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
