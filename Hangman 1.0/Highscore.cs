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
        #region Class Variables

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

        #endregion

        #region Properties

        public static string[] HighScores
        {
            get { return highScores; }
            set { highScores = value; }
        }
        public static string[] SplitHighScores
        {
            get { return splitHighScores; }
            set { splitHighScores = value; }
        }
        // Property pertaining to aforementioned points
        public static int Score
        {
            get { return score; }
            set { score = value; }
        }

        #endregion

        #region Highscore Methods

        // Method referenced in Game.cs
        public static void CalculateScore() //  Räknar ut poäng och anropar metod för jämförelse med highscorelistan
        {
            // Score output to the user
            score = (Player.PlayerLife * Story.RandomWord.Length * Game.RightGuesses * Story.DifficultyLevel) - Game.WrongGuesses;
            
            // Method that determines whether score is eligible for the highscore list
            PrintScore();
        }
        public static void PrintScore() //  Läser in highscorelistan och delar upp i namn och poäng
        {
            HighScores = File.ReadAllLines(@"Highscore.txt");
            highScoreNames = new string[HighScores.Length];
            highScorePoints = new int[HighScores.Length];
            tempNames = new string[HighScores.Length];
            tempPoints = new int[HighScores.Length];

            for (int i = 0; i < HighScores.Length; i++)
            {
                SplitHighScores = HighScores[i].Split(' ');
                highScoreNames[i] = SplitHighScores[0];
                highScorePoints[i] = Int32.Parse(SplitHighScores[1]);
                tempNames[i] = highScoreNames[i];
                tempPoints[i] = highScorePoints[i];
            }

            IsScoreEligibleForList();
            WriteData();
        }
        private static void IsScoreEligibleForList()    //  Kollar om poängen räcker för highscore
        {
            for (int i = 0; i < HighScores.Length; i++)
            {
                if (score >= highScorePoints[i])
                {
                    // Replace player and score
                    highScorePoints[i] = score;
                    highScoreNames[i] = Player.PlayerName;

                    // Populate each subsequent row with the row above
                    for (int j = i; j < HighScores.Length; j++)
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
        private static void WriteData() //  Skriver highscorelistan till fil
        {
            for (int i = 0; i < highScoreNames.Length; i++)
            {
                HighScores[i] = highScoreNames[i] + " " + highScorePoints[i];
            }
            File.WriteAllLines(@"Highscore.txt", HighScores);
        }

        #endregion
    }
}
