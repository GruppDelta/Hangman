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
                Console.WriteLine("\t 2 - Highscores\n");
                Console.WriteLine("----------------------------------");
                Console.Write("\tPick storyline: ");

                switch (choice = Console.ReadLine())
                {
                    case "1":
                        GameMenu(playerName);
                        break;
                    case "2":
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

        #region Story Graphics

        public static string EasyGraphics(int playerLives)
        {
            switch (playerLives)
            {
                case 1000:
                    Highscore.CalculateScore();
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                             ________               ║" + Environment.NewLine +
@" ║                                                                                            /        \              ║" + Environment.NewLine +
@" ║            _____________________________________________________________________        __/       (o)\__           ║" + Environment.NewLine +
@" ║           |                                                                     \      /     ______\\   \          ║" + Environment.NewLine +
@" ║           |  Smashing! Good job commander. You saved the city.                   \     |____/__  __\____|          ║" + Environment.NewLine +
@" ║           |  Well, most of it. I will reccomend you for a promotion!              >       [  --~~--  ]             ║" + Environment.NewLine +
 " ║           |  Our oursourced investigation team rated you " + Highscore.Score + "                      /         |(  L   )|              ║" + Environment.NewLine +
@" ║           |  points of a scale to Failure to Master Chief Commander Sergeant    /    ___----\  __  /----___        ║" + Environment.NewLine +
@" ║           |                                                                    /   /   |  < \____/ >   |   \       ║" + Environment.NewLine +
@" ║           |  Once again. Smashing performance. This will go on your record!   /   /    |   < \--/ >    |    \      ║" + Environment.NewLine +
@" ║           |__________________________________________________________________/    ||||||    \ \/ /     ||||||      ║" + Environment.NewLine +
@" ║                                                                                   |          \  /   o       |      ║" + Environment.NewLine +
@" ║                                                                                   |     |     \/   === |    |      ║" + Environment.NewLine +
@" ║                                                                                   |     |      |o  ||| |    |      ║" + Environment.NewLine +
@" ║                                                                                   |     \______|   +#* |    |      ║" + Environment.NewLine +
@" ║                                                                                   |            |o      |    |      ║" + Environment.NewLine +
@" ║                                                                                    \           |      /     /      ║" + Environment.NewLine +
@" ║                                                                                    |\__________|o    /     /       ║" + Environment.NewLine +
@" ║                                                                                    |           |    /     /        ║" + Environment.NewLine;
                case 8:
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║    __   __                     ___                ^                         __   __                     ___        ║" + Environment.NewLine +
@" ║   |  | |  |      /|           |   |  _______     ^^^                       |  | |  |      /|           |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  _  | |__         |   |_|xxxxxxx|  _^^^^^_      _              |  | |  |  _  | |__         |   |       ║" + Environment.NewLine +
@" ║   |  | |  |_| | | |  |/\_     |   | |xxxxxxx| | [][]  |   _/ \_          __|  | |  |_| | | |  |/\_     |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  | | __| |  |   |_   ______xxxxx| |[][][] |_-/     \-_     _|  |  | |  | | __| |  |   |_   |   |       ║" + Environment.NewLine +
@" ║   |  | | ^|  | ||  | |  |   | |_|++++++|xxxx| | [][][]|  \     /  |___| |  |  |^|  | ||  | |  |   | |__|   |       ║" + Environment.NewLine +
@" ║   |  | | ||  | ||  | |  |   | |_|++++++|xxxx| |[][][] |   |___|   |   | |  |  |||  | ||  | |  |   | /\ |   |       ║" + Environment.NewLine +
@" ║   ~~~~~~~~~~~~~~~~~~~~~~~~~~|___|++++++|_________ [][]|   |   |   |   | |  =================================       ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=| [] |   |   |   |   | |_/                                        ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=|[][]|                                                            ║" + Environment.NewLine +
@" ║                                 |++HH++|  _HHHH__|                                                                 ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║               __                   ___   __                                                                        ║" + Environment.NewLine +
@" ║              |**|  ___    _   __  |***| |**| ___   _                                                               ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |**||***| |*|                                                              ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |**||***| |*|                                                              ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |**||***| |*|                                                              ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine;
                case 7:
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║    __   __                     ___                ^                         __   __                     ___        ║" + Environment.NewLine +
@" ║   |  | |  |      /|           |   |  _______     ^^^                       |  | |  |      /|           |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  _  | |__         |   |_|xxxxxxx|  _^^^^^_      _              |  | |  |  _  | |__         |   |       ║" + Environment.NewLine +
@" ║   |  | |  |_| | | |  |/\_     |   | |xxxxxxx| | [][]  |   _/ \_          __|  | |  |_| | | |  |/\_     |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  | | __| |  |   |_   ______xxxxx| |[][][] |_-/     \-_     _|  |  | |  | | __| |  |   |_   |   |       ║" + Environment.NewLine +
@" ║   |  | | ^|  | ||  | |  |   | |_|++++++|xxxx| | [][][]|  \     /  |___| |  |  |^|  | ||  | |  |   | |__|   |       ║" + Environment.NewLine +
@" ║   |  | | ||  | ||  | |  |   | |_|++++++|xxxx| |[][][] |   |___|   |   | |  |  |||  | ||  | |  |   | /\ |   |       ║" + Environment.NewLine +
@" ║   ~~~~~~~~~~~~~~~~~~~~~~~~~~|___|++++++|_________ [][]|   |   |   |   | |  =================================       ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=| [] |   |   |   |   | |_/                                        ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=|[][]|                                                            ║" + Environment.NewLine +
@" ║                                 |++HH++|  _HHHH__|                                                                 ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║               __                   ___   __                    *EXPLOSIONS!*                                       ║" + Environment.NewLine +
@" ║              |**|  ___    _   __  |***| |**| ___                                                                   ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |**||***|                                                                  ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |**||***|                                                                  ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |**||***| |x|                                                              ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine;
                case 6:
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║    __   __                     ___                ^                         __   __                     ___        ║" + Environment.NewLine +
@" ║   |  | |  |      /|           |   |  _______     ^^^                       |  | |  |      /|           |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  _  | |__         |   |_|xxxxxxx|  _^^^^^_      _              |  | |  |  _  | |__         |   |       ║" + Environment.NewLine +
@" ║   |  | |  |_| | | |  |/\_     |   | |xxxxxxx| | [][]  |   _/ \_          __|  | |  |_| | | |  |/\_     |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  | | __| |  |   |_   ______xxxxx| |[][][] |_-/     \-_     _|  |  | |  | | __| |  |   |_   |   |       ║" + Environment.NewLine +
@" ║   |  | | ^|  | ||  | |  |   | |_|++++++|xxxx| | [][][]|  \     /  |___| |  |  |^|  | ||  | |  |   | |__|   |       ║" + Environment.NewLine +
@" ║   |  | | ||  | ||  | |  |   | |_|++++++|xxxx| |[][][] |   |___|   |   | |  |  |||  | ||  | |  |   | /\ |   |       ║" + Environment.NewLine +
@" ║   ~~~~~~~~~~~~~~~~~~~~~~~~~~|___|++++++|_________ [][]|   |   |   |   | |  =================================       ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=| [] |   |   |   |   | |_/                                        ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=|[][]|                                                            ║" + Environment.NewLine +
@" ║                                 |++HH++|  _HHHH__|                                                                 ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║               __                   ___   __                                                                        ║" + Environment.NewLine +
@" ║              |**|  ___    _   __  |***| |**|                      *KNACK KNAK*                                     ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |**|                                                                       ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |**|                                                                       ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |**||x%x| |x|                                                              ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine;
                case 5:
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║    __   __                     ___                ^                         __   __                     ___        ║" + Environment.NewLine +
@" ║   |  | |  |      /|           |   |  _______     ^^^                       |  | |  |      /|           |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  _  | |__         |   |_|xxxxxxx|  _^^^^^_      _              |  | |  |  _  | |__         |   |       ║" + Environment.NewLine +
@" ║   |  | |  |_| | | |  |/\_     |   | |xxxxxxx| | [][]  |   _/ \_          __|  | |  |_| | | |  |/\_     |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  | | __| |  |   |_   ______xxxxx| |[][][] |_-/     \-_     _|  |  | |  | | __| |  |   |_   |   |       ║" + Environment.NewLine +
@" ║   |  | | ^|  | ||  | |  |   | |_|++++++|xxxx| | [][][]|  \     /  |___| |  |  |^|  | ||  | |  |   | |__|   |       ║" + Environment.NewLine +
@" ║   |  | | ||  | ||  | |  |   | |_|++++++|xxxx| |[][][] |   |___|   |   | |  |  |||  | ||  | |  |   | /\ |   |       ║" + Environment.NewLine +
@" ║   ~~~~~~~~~~~~~~~~~~~~~~~~~~|___|++++++|_________ [][]|   |   |   |   | |  =================================       ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=| [] |   |   |   |   | |_/                                        ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=|[][]|                                                            ║" + Environment.NewLine +
@" ║                                 |++HH++|  _HHHH__|                                                                 ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║               __                   ___                                                                             ║" + Environment.NewLine +
@" ║              |**|  ___    _   __  |***|                           *POOF SMACK*                                     ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***|                                                                            ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***|                                                                            ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |***| |xx||x%x| |x|                                                              ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine;
                case 4:
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║    __   __                     ___                ^                         __   __                     ___        ║" + Environment.NewLine +
@" ║   |  | |  |      /|           |   |  _______     ^^^                       |  | |  |      /|           |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  _  | |__         |   |_|xxxxxxx|  _^^^^^_      _              |  | |  |  _  | |__         |   |       ║" + Environment.NewLine +
@" ║   |  | |  |_| | | |  |/\_     |   | |xxxxxxx| | [][]  |   _/ \_          __|  | |  |_| | | |  |/\_     |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  | | __| |  |   |_   ______xxxxx| |[][][] |_-/     \-_     _|  |  | |  | | __| |  |   |_   |   |       ║" + Environment.NewLine +
@" ║   |  | | ^|  | ||  | |  |   | |_|++++++|xxxx| | [][][]|  \     /  |___| |  |  |^|  | ||  | |  |   | |__|   |       ║" + Environment.NewLine +
@" ║   |  | | ||  | ||  | |  |   | |_|++++++|xxxx| |[][][] |   |___|   |   | |  |  |||  | ||  | |  |   | /\ |   |       ║" + Environment.NewLine +
@" ║   ~~~~~~~~~~~~~~~~~~~~~~~~~~|___|++++++|_________ [][]|   |   |   |   | |  =================================       ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=| [] |   |   |   |   | |_/                                        ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=|[][]|                                                            ║" + Environment.NewLine +
@" ║                                 |++HH++|  _HHHH__|                                                                 ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║               __                                                                                                   ║" + Environment.NewLine +
@" ║              |**|  ___    _   __                                  *KLIRR BOOOM*                                    ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**|                                                                                  ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**|                                                                                  ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |**| |x%x |xx||x%x| |x|                                                               ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine;
                case 3:
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║    __   __                     ___                ^                         __   __                     ___        ║" + Environment.NewLine +
@" ║   |  | |  |      /|           |   |  _______     ^^^                       |  | |  |      /|           |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  _  | |__         |   |_|xxxxxxx|  _^^^^^_      _              |  | |  |  _  | |__         |   |       ║" + Environment.NewLine +
@" ║   |  | |  |_| | | |  |/\_     |   | |xxxxxxx| | [][]  |   _/ \_          __|  | |  |_| | | |  |/\_     |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  | | __| |  |   |_   ______xxxxx| |[][][] |_-/     \-_     _|  |  | |  | | __| |  |   |_   |   |       ║" + Environment.NewLine +
@" ║   |  | | ^|  | ||  | |  |   | |_|++++++|xxxx| | [][][]|  \     /  |___| |  |  |^|  | ||  | |  |   | |__|   |       ║" + Environment.NewLine +
@" ║   |  | | ||  | ||  | |  |   | |_|++++++|xxxx| |[][][] |   |___|   |   | |  |  |||  | ||  | |  |   | /\ |   |       ║" + Environment.NewLine +
@" ║   ~~~~~~~~~~~~~~~~~~~~~~~~~~|___|++++++|_________ [][]|   |   |   |   | |  =================================       ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=| [] |   |   |   |   | |_/                                        ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=|[][]|                                                            ║" + Environment.NewLine +
@" ║                                 |++HH++|  _HHHH__|                                                                 ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║               __                                                                                                   ║" + Environment.NewLine +
@" ║              |**|  ___    _                                       *BAUTABANG*                                      ║" + Environment.NewLine +
@" ║              |**| |***|  |*|                                                                                       ║" + Environment.NewLine +
@" ║              |**| |***|  |*|                                                                                       ║" + Environment.NewLine +
@" ║              |**| |***|  |*| |xx| |x%x |xx||x%x| |x|                                                               ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine;
                case 2:
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║    __   __                     ___                ^                         __   __                     ___        ║" + Environment.NewLine +
@" ║   |  | |  |      /|           |   |  _______     ^^^                       |  | |  |      /|           |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  _  | |__         |   |_|xxxxxxx|  _^^^^^_      _              |  | |  |  _  | |__         |   |       ║" + Environment.NewLine +
@" ║   |  | |  |_| | | |  |/\_     |   | |xxxxxxx| | [][]  |   _/ \_          __|  | |  |_| | | |  |/\_     |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  | | __| |  |   |_   ______xxxxx| |[][][] |_-/     \-_     _|  |  | |  | | __| |  |   |_   |   |       ║" + Environment.NewLine +
@" ║   |  | | ^|  | ||  | |  |   | |_|++++++|xxxx| | [][][]|  \     /  |___| |  |  |^|  | ||  | |  |   | |__|   |       ║" + Environment.NewLine +
@" ║   |  | | ||  | ||  | |  |   | |_|++++++|xxxx| |[][][] |   |___|   |   | |  |  |||  | ||  | |  |   | /\ |   |       ║" + Environment.NewLine +
@" ║   ~~~~~~~~~~~~~~~~~~~~~~~~~~|___|++++++|_________ [][]|   |   |   |   | |  =================================       ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=| [] |   |   |   |   | |_/                                        ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=|[][]|                                                            ║" + Environment.NewLine +
@" ║                                 |++HH++|  _HHHH__|                                                                 ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║               __                                                                                                   ║" + Environment.NewLine +
@" ║              |**|  ___                                            *CRASH BOOM*                                     ║" + Environment.NewLine +
@" ║              |**| |***|                                                                                            ║" + Environment.NewLine +
@" ║              |**| |***|                                                                                            ║" + Environment.NewLine +
@" ║              |**| |***|  |x| |xx| |x%x |xx||x%x| |x|                                                               ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine;
                case 1:
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║    __   __                     ___                ^                         __   __                     ___        ║" + Environment.NewLine +
@" ║   |  | |  |      /|           |   |  _______     ^^^                       |  | |  |      /|           |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  _  | |__         |   |_|xxxxxxx|  _^^^^^_      _              |  | |  |  _  | |__         |   |       ║" + Environment.NewLine +
@" ║   |  | |  |_| | | |  |/\_     |   | |xxxxxxx| | [][]  |   _/ \_          __|  | |  |_| | | |  |/\_     |   |       ║" + Environment.NewLine +
@" ║   |  | |  |  | | __| |  |   |_   ______xxxxx| |[][][] |_-/     \-_     _|  |  | |  | | __| |  |   |_   |   |       ║" + Environment.NewLine +
@" ║   |  | | ^|  | ||  | |  |   | |_|++++++|xxxx| | [][][]|  \     /  |___| |  |  |^|  | ||  | |  |   | |__|   |       ║" + Environment.NewLine +
@" ║   |  | | ||  | ||  | |  |   | |_|++++++|xxxx| |[][][] |   |___|   |   | |  |  |||  | ||  | |  |   | /\ |   |       ║" + Environment.NewLine +
@" ║   ~~~~~~~~~~~~~~~~~~~~~~~~~~|___|++++++|_________ [][]|   |   |   |   | |  =================================       ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=| [] |   |   |   |   | |_/                                        ║" + Environment.NewLine +
@" ║                                 |++++++|=|=|=|=|=|[][]|                                                            ║" + Environment.NewLine +
@" ║                                 |++HH++|  _HHHH__|                                                                 ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║               __                                                                                                   ║" + Environment.NewLine +
@" ║              |**|                                                 *CRASH BOOM*                                     ║" + Environment.NewLine +
@" ║              |**|                                                                                                  ║" + Environment.NewLine +
@" ║              |**|                                                                                                  ║" + Environment.NewLine +
@" ║              |**| |x%x|  |*| |xx| |x%x |xx||x%x| |x|                                                               ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine;
                case 0:
                    return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║       __                         ___                                         __   _                                ║" + Environment.NewLine +
@" ║      |    |     /|            |   |  _______     ^^^                       |  | | |   /                            ║" + Environment.NewLine +
@" ║     |    |  _  | __          |    |_|xxxxx|  _^^^^_       _              |   |     |  _   ||__                     ║" + Environment.NewLine +
@" ║      | _  | | |/_       |     | |xxxxxx| |[]]         |  _/_           __ |  | |  |_| | |    |/\_                  ║" + Environment.NewLine +
@" ║     | |      __| |    |_   ____xx| |[[] ] |_/     \- _     _|             |   | |  | |__  |  |   |_    |   |       ║" + Environment.NewLine +
@" ║   |  | | ^|  | ||   | |  |    |||++++|xxx x| |[]][]|   \     /  |___|  |  |   |^| | ||  | |   |   | |__|   |       ║" + Environment.NewLine +
@" ║   |  | | ||  | ||  | |  |    |||++++xx   | |[[] [ ]  |   |___|   |   | |   |  |||  | ||  | |  |   | /\ |   |       ║" + Environment.NewLine +
@" ║   ~~~~~~~~~~~~~~~~~~~~~~~~~~ |___|++|_____ ____ [][]|   |   |   |   | |    =================================       ║" + Environment.NewLine +
@" ║                                  |+++++|=|=|=|=|=| [] |   |   |   |   | |_/                                        ║" + Environment.NewLine +
@" ║                                       |++++++|=|=|[][]|                                                            ║" + Environment.NewLine +
@" ║                                 |++HH++|  _HHHH__|                                                                 ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║            *BAUTA CRASH BADABOOM KAKLIRR KNARR SLAP KNOCK SWOSH TSONG BOOOOOM*                                     ║" + Environment.NewLine +
@" ║            The bad guys won today. Let us hope that your replacement won't be so ... disappointing.                ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine +
@" ║              |**| |x%x|  |*| |xx| |x%x |xx||x%x| |x|                                                               ║" + Environment.NewLine +
@" ║                                                                                                                    ║" + Environment.NewLine;

                default: return @"" +
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + Environment.NewLine +
@" ║                                                                                             ________               ║" + Environment.NewLine +
@" ║                                                                                            /        \              ║" + Environment.NewLine +
@" ║            _____________________________________________________________________        __/       (o)\__           ║" + Environment.NewLine +
@" ║           |                                                                     \      /     ______\\   \          ║" + Environment.NewLine +
@" ║           |  Greeting commander. You have been chosen for your superior          \     |____/__  __\____|          ║" + Environment.NewLine +
@" ║           |  intellect to handle a delicate terrorist situation. The              >       [  --~~--  ]             ║" + Environment.NewLine +
@" ║           |  terrorists threaten to destroy an entire city unless                /         |(  L   )|              ║" + Environment.NewLine +
@" ║           |  we decipher their codeword. To make matters worse, they            /    ___----\  __  /----___        ║" + Environment.NewLine +
@" ║           |  intend to destroy a building for every wrong guess we make.       /   /   |  < \____/ >   |   \       ║" + Environment.NewLine +
@" ║           |  They are giving us eight attempts. Make 'em count commander.     /   /    |   < \--/ >    |    \      ║" + Environment.NewLine +
@" ║           |__________________________________________________________________/    ||||||    \ \/ /     ||||||      ║" + Environment.NewLine +
@" ║                                                                                   |          \  /   o       |      ║" + Environment.NewLine +
@" ║                                                                                   |     |     \/   === |    |      ║" + Environment.NewLine +
@" ║                                                                                   |     |      |o  ||| |    |      ║" + Environment.NewLine +
@" ║                                                                                   |     \______|   +#* |    |      ║" + Environment.NewLine +
@" ║                                                                                   |            |o      |    |      ║" + Environment.NewLine +
@" ║                                                                                    \           |      /     /      ║" + Environment.NewLine +
@" ║                                                                                    |\__________|o    /     /       ║" + Environment.NewLine +
@" ║                                                                                    |           |    /     /        ║" + Environment.NewLine;
            }

            return "";
        }

        public static string MediumGraphics(int playerLives)
        {

            switch (playerLives)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
                default: break;
            }

            return "";
        }

        public static string HardGrahpics(int playerLives)
        {

            switch (playerLives)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                default: break;
            }

            return "";
        }

        #endregion
    }
}
