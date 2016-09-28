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
        // Gathers data from each row from the txt file
        private static string[] highScores;

        // Splits each row into separate containers for name and points
        private static string[] splitHighScores;

        // Array with names and points from the list
        private static string[] highScoreNames;
        private static int[] highScorePoints;

        private static string[] tempNames;
        private static int[] tempPoints;

        // Points achieved during the game
        private static int score;

        private const int maxNumOfScores = 5;

        // Property pertaining to aforementioned points
        public static int Score
        {
            get { return score; }
            set { score = value; }
        }

        // Method referenced in Game.cs
        public static void CalculateScore()
        {
            // Score output to the user
            score = Player.PlayerLife * Story.DifficultyLevel;
            
            // Method that determines whether score is eligible for the highscore list
            PrintScore();
        }

        public static void PrintScore()
        {
            highScores = File.ReadAllLines(@"Highscore.txt");
            highScoreNames = new string[highScores.Length];
            highScorePoints = new int[highScores.Length];
            tempNames = new string[highScores.Length];
            tempPoints = new int[highScores.Length];

            for (int i = 0; i < highScores.Length; i++)
            {
                splitHighScores = highScores[i].Split(' ');
                highScoreNames[i] = splitHighScores[0];
                highScorePoints[i] = Int32.Parse(splitHighScores[1]);
                tempNames[i] = highScoreNames[i];
                tempPoints[i] = highScorePoints[i];
            }

            IsScoreEligibleForList();
            WriteData();
        }

        private static void IsScoreEligibleForList()
        {
            for (int i = 0; i < highScores.Length; i++)
            {
                if (score >= highScorePoints[i])
                {
                    // Replace player and score
                    highScorePoints[i] = score;
                    highScoreNames[i] = Player.PlayerName;

                    // Populate each subsequent row with the row above
                    for (int j = i; j < highScores.Length; j++)
                    {
                        // Making sure to discard the 6th element in the array
                        // 6th element created as a consequence of moving the individual rows 1 step down
                        if (j + 1 < maxNumOfScores)
                        {
                            highScorePoints[j + 1] = tempPoints[j];
                            highScoreNames[j + 1] = tempNames[j];
                        }
                    }
                    break;
                }
            }
        }

        private static void WriteData()
        {
            for (int i = 0; i < highScoreNames.Length; i++)
            {
                highScores[i] = highScoreNames[i] + " " + highScorePoints[i];
            }

            File.WriteAllLines(@"Highscore.txt", highScores);
        }
    }
}
