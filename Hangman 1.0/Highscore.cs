using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hangman_1._0
{
    class Highscore
    {

        private static string[] highScores;
        private static string[] splitNames;
        private static int[] splitScores;
        private static int gameScore;
        private static string scoreText;

        public static void CalculateScore()
        {
            gameScore = Player.PlayerLife * Story.DifficultyLevel;
            Console.Clear();
            Console.WriteLine(gameScore);
            Console.ReadKey();
            CompareScores();
        }

        private static void CompareScores()
        {
            highScores = File.ReadAllLines(@"Highscore\Scores.txt");
            splitNames = new string[highScores.Length];
            splitScores = new int[highScores.Length];
            string[] splitString;

            // Split scores and names
            for (int i = 0; i < highScores.Length; i++)
            {
                splitString = highScores[i].Split(' ');
                splitNames[i] = splitString[0];
                splitScores[i] = Int32.Parse(splitString[1]);
            }

            //int[] tempScore = new int[splitScores.Length + 1];
            //string[] tempName = new string[splitNames.Length + 1];

            int[] tempScore = new int[splitScores.Length - 1];
            string[] tempName = new string[splitNames.Length - 1];

            // Determine whether gameScore is eligible for the High scores list
            for (int i = 0; i < splitScores.Length; i++)
            {
                if (gameScore > splitScores[i])
                {

                    for (int j = i; j < splitScores.Length; j++)
                    {
                        tempScore[j] = splitScores[j];
                        tempName[j] = splitNames[j];

                        if (j + 1 < splitScores.Length)
                        {
                            splitScores[j + 1] = tempScore[j];
                            splitNames[j + 1] = tempName[j];
                        }
                    }

                    splitScores[i] = gameScore;
                    splitNames[i] = Player.PlayerName;
                }
            }

            PrintScore();
        }

        private static void PrintScore()
        {

            for (int i = 0; i < splitScores.Length; i++)
            {
                scoreText += splitNames[i] + " " + splitScores[i] + Environment.NewLine;
            }

            File.WriteAllText(@"Highscore\Scores.txt", scoreText);
        }
    }
}
