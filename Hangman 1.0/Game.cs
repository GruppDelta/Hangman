using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class Game
    {
        #region Class Variables

        private const bool isUsingExperimentalGraphics = true;

        private static bool hasStoryInfoBeenShown = false;
        private static string experimentalStringToTellUserOnNextIteration = "  ";

        private static bool didThePlayerWin;
        private static bool isGameOver;
        private static int rightGuesses;
        private static int wrongGuesses;
        private static string[] maskedWord;
        private static string[] rightLetters;
        private static string[] wrongLetters;

        #endregion

        #region Properties

        public static bool IsGameOver
        {
            get { return isGameOver; }
            set { isGameOver = value; }
        }
        public static int RightGuesses
        {
            get { return rightGuesses; }
            set { rightGuesses = value; }
        }
        public static int WrongGuesses
        {
            get { return wrongGuesses; }
            set { wrongGuesses = value; }
        }
        public static string[] MaskedWord
        {
            get { return maskedWord; }
            set { maskedWord = value; }
        }
        public static string[] RightLetters
        {
            get { return rightLetters; }
            set { rightLetters = value; }
        }
        public static string[] WrongLetters
        {
            get { return wrongLetters; }
            set { wrongLetters = value; }
        }

        #endregion

        #region Game Methods

        public static void GameLoop()      //  Spelloop
        {
            bool isGameLoopOver = false;
            string maskedWordString;


            MaskedWord = new string[Story.RandomWord.Length];
            RightLetters = new string[Story.RandomWord.Length];
            WrongLetters = new string[Player.PlayerLife];
            RightGuesses = 0;
            WrongGuesses = 0;

            ArrayInitiation();

            //  Startar spelloopen.
            do
            {
                isGameLoopOver = GameEngine();
                maskedWordString = TempString(MaskedWord);
            } while (Story.RandomWord != maskedWordString && isGameLoopOver == false);

            didThePlayerWin = isGameLoopOver;

            if (!isUsingExperimentalGraphics)
            {
                PlayingField();
                GameResult(isGameLoopOver);
            }

        }
        public static void ArrayInitiation()    //  Initierar alla fält
        {
            //  Initierar fälten och lägger in minustecken för varje bokstav i det dolda ordet.
            for (int hiddenLetter = 0; hiddenLetter < Story.RandomWord.Length; hiddenLetter++)
            {
                MaskedWord[hiddenLetter] = "-";
            }
            //  Initierar fälten för korrekta gissningar.
            for (int hiddenLetter = 0; hiddenLetter < Story.RandomWord.Length; hiddenLetter++)
            {
                RightLetters[hiddenLetter] = " ";
            }
            //  Initierar fälten för felaktiga gissningar.
            for (int hiddenLetter = 0; hiddenLetter < Player.PlayerLife; hiddenLetter++)
            {
                WrongLetters[hiddenLetter] = " ";
            }
        }
        public static string TempString(string[] tempStringArray)   //  Bygger en temporär sträng
        {
            string tempString = string.Empty;

            for (int i = 0; i < tempStringArray.Length; i++)
            {
                tempString += tempStringArray[i];
            }

            return tempString;
        }

        public static void ExperimentalPlayingField(string inputMessageToPlayer)
        {
            string tempMaskedString = "";
            string tempGuessedString = "";

            foreach(string s in MaskedWord)
            {
                tempMaskedString += s;
            }

            foreach (string s in wrongLetters)
            {
                tempGuessedString += s;
            }

            if (!hasStoryInfoBeenShown)
            {

                switch (Story.DifficultyLevel)
                {
                    case 1:
                        GFX.UpdateTopBoxOfScreen(GFX.FormatTopBox(Story.EasyGraphics(-5000)));
                        GFX.UpdateMiddleBoxOfScreen(GFX.FormatMiddleBox(tempMaskedString, tempGuessedString));
                        break;
                    case 2:
                        break;
                    case 3:
                        break;

                }

                GFX.DrawAllPartsOfScreen();

                hasStoryInfoBeenShown = true;
                Console.ReadKey();
            }


            switch (Story.DifficultyLevel)
            {
                case 1:
                    GFX.UpdateTopBoxOfScreen(GFX.FormatTopBox(Story.EasyGraphics(Player.PlayerLife)));
                    GFX.UpdateMiddleBoxOfScreen(GFX.FormatMiddleBox(tempMaskedString, tempGuessedString));
                    GFX.UpdateBottomBoxOfScreen(GFX.FormatBottomBox(inputMessageToPlayer));

                    Console.SetCursorPosition((int)GFX.BoxPos.BottomBoxWritingLeft, (int)GFX.BoxPos.BottomBoxWritingTop);
                    break;
                case 2: break;
                case 3: break;
            }


        }
        public static void PlayingField()  //  Ritar upp spelplanen, frågar efter bokstav samt returnerar värde.
        {

            Console.Clear();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("   Category: " + Story.Category);
            Console.WriteLine("----------------------------------");
            Console.Write("\n\tSecret word: ");
            for (int i = 0; i < Story.RandomWord.Length; i++)
            {
                Console.Write(MaskedWord[i]);
            }
            Console.WriteLine("\n\n----------------------------------");
            Console.Write("\tUsed letters:\n     ");

            for (int i = 0; i < WrongLetters.Length; i++)
            {
                Console.Write(WrongLetters[i] + " ");
            }

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("    You have " + Player.PlayerLife + " guesses left.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n\n\n----------------------------------");
        }
        public static bool GameEngine()    //  Spelmotor.
        {
            string[] usedLetters = new string[Story.RandomWord.Length];
            string input;
            bool isGameWon;
            bool isRightGuess;
            //  Har spelaren liv kvar?
            if (Player.PlayerLife > 0)
            {
                {
                    //  Ritar upp spelplan och frågar efter bokstav. 
                    
                    do
                    {
                        if (isUsingExperimentalGraphics)
                            ExperimentalPlayingField(experimentalStringToTellUserOnNextIteration);
                        else
                            PlayingField();

                        input = GuessLetter();
                    } while (input.Length != 1);
                    isRightGuess = false;
                    //  Finns bokstaven i det dolda ordet?
                    for (int guessedLetter = 0; guessedLetter < Story.RandomWord.Length; guessedLetter++)
                    {
                        //  Kollar om bokstaven finns och byter ut minustecken mot denna.
                        if (input[0] == Story.RandomWord[guessedLetter])
                        {
                            MaskedWord[guessedLetter] = input;
                            isRightGuess = true;
                        }
                    }
                    //  Bokstaven finns inte med i det hemliga ordet.
                    if (!isRightGuess)
                    {
                        //  Kollar om den felaktiga gissningen använts tidigare.
                        for (int guessedLetter = 0; guessedLetter < WrongLetters.Length; guessedLetter++)
                        {
                            if (input == WrongLetters[guessedLetter])
                            {
                                //  Meddelar att gissningen använts tidigare.
                                if (isUsingExperimentalGraphics)
                                    experimentalStringToTellUserOnNextIteration = "You already guessed this letter.";
                                else
                                {
                                    PlayingField();
                                    AlreadyUsedLetter();
                                }

                                
                                isRightGuess = true;
                            }
                        }
                        //  Bokstaven är fel men har inte använts tidigare.
                        if (!isRightGuess)
                        {
                            if (isUsingExperimentalGraphics)
                                experimentalStringToTellUserOnNextIteration = "This letter is incorrect.";
                            else
                            {
                                PlayingField();
                                WrongGuess();
                            }
                            
                            //  Lagrar gissningen i första fältet för felaktiga gissningar.
                            WrongLetters[WrongGuesses] = input;
                            //  Byter till nästa fält för felaktiga gissningar.
                            WrongGuesses++;
                            //  Räknar ner ett liv.
                            Player.PlayerLife--;
                        }
                    }
                    //  Bokstaven finns med i det hemliga ordet.
                    else
                    {
                        bool used = false;
                        //  Kollar om den korrekta gissningen har använts tidigare.
                        for (int guessedLetter = 0; guessedLetter < Story.RandomWord.Length; guessedLetter++)
                        {
                            if (input == RightLetters[guessedLetter])
                            {
                                used = true;
                            }
                        }
                        //  Bokstaven är korrekt men har inte använts tidigare.
                        if (!used)
                        {
                            if (isUsingExperimentalGraphics)
                                experimentalStringToTellUserOnNextIteration = "Correct";
                            else
                            {
                                PlayingField();
                                RightGuess();
                            }
                            //  Lagrar gissningen i första fältet för korrekta gissningar.
                            RightLetters[RightGuesses] = input;
                            //  Byter till nästa fält för korrekta gissningar.
                            RightGuesses++;
                        }
                        else
                        {
                            //  Meddelar att gissningen använts tidigare.
                            if (isUsingExperimentalGraphics)
                                experimentalStringToTellUserOnNextIteration = "You already Guessed this letter";
                            else
                            {
                                PlayingField();
                                AlreadyUsedLetter();
                            }


                        }
                    }
                }
                //  Spelet fortsätter; rätt gissning eller återstående liv. 
                isGameWon = false;
                return isGameWon;
            }
            else
            {
                //  Spelet avslutas; liven har tagit slut.
                isGameWon = true;
                return isGameWon;
            }
        }
        public static string GuessLetter()
        {
            //Console.Write("\tGuess a letter: ");
            string tempInput = Console.ReadLine().ToUpper();
            return tempInput;
        }
        public static void AlreadyUsedLetter() //  Meddelar att bokstaven redan har använts.
        {
            Console.WriteLine("You have already used that letter.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n     Press any key to continue\n");
            Console.WriteLine("----------------------------------");
            Console.ReadKey();
        }
        public static void RightGuess()    //  Meddelar att gissningen är korrekt.
        {
            Console.WriteLine("      The letter is correct!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n     Press any key to continue\n");
            Console.WriteLine("----------------------------------");
            Console.ReadKey();
        }
        public static void WrongGuess()    //  Meddelar att gissningen är fel.
        {
            Console.WriteLine("       The letter is wrong!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n     Press any key to continue\n");
            Console.WriteLine("----------------------------------");
            Console.ReadKey();
        }
        public static void GameResult(bool isGameWon)   //  Vinst eller förlust?
        {
            if (isGameWon)
            {
                Console.WriteLine("\t    You lost!");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("\n     Press any key to continue\n");
                Console.WriteLine("----------------------------------");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\t    You won!");
                // Display achieved score to the user as well as determine whether score is eligible for the highscore list 
                Highscore.CalculateScore();
                Console.WriteLine(" You scored {0} points this game.", Highscore.Score);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("\n     Press any key to continue\n");
                Console.WriteLine("----------------------------------");
                Console.ReadKey();
            }
        }
        public static void Restart()                 //  Spela igen?
        {
            string playAgain;

            do
            {
                if (isUsingExperimentalGraphics)
                {
                    if (Player.PlayerLife > 0)
                    {
                        GFX.UpdateTopBoxOfScreen(GFX.FormatTopBox(Story.EasyGraphics(1000)));
                    }
                    else
                    {
                        GFX.UpdateTopBoxOfScreen(GFX.FormatTopBox(Story.EasyGraphics(Player.PlayerLife)));
                    }
                }

                else
                    PlayingField();

                Console.Write("\tPlay again (Y/N): ");
                playAgain = Console.ReadLine().ToUpper();
            } while (playAgain.Length != 1);

            switch (playAgain)
            {
                case "Y":
                    break;
                case "N":
                    Console.Clear();
                    Console.WriteLine("\n----------------------------------");
                    Console.WriteLine("\n\tThanks for playing!");
                    Console.WriteLine("\n----------------------------------");
                    Console.WriteLine("\n     Press any key to continue\n");
                    Console.WriteLine("----------------------------------");
                    Console.ReadKey();
                    IsGameOver = true;
                    break;
                default:
                    Restart();
                    break;
            }
        }

        #endregion
    }
}
