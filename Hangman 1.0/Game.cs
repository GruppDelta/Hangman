using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class Game
    {
        public static int rightGuesses;
        public static int wrongGuesses;
        public static int playerGuesses;
        public static string[] maskedWord;
        public static string[] rightLetters;
        public static string[] wrongLetters;
        public static string maskedWordString;

        public static void GameLoop()      //  Spelloop
        {
            bool isGameLoopOver;
            Program.isGameOver = false;
            playerGuesses = Story.playerLife;
            wrongGuesses = 0;
            rightGuesses = 0;
            ArrayInitiation();
            //  Startar spelloopen.
            do
            {
                isGameLoopOver = GameEngine();
                maskedWordString = TempString(maskedWord);
            } while (Story.randomWord != maskedWordString && isGameLoopOver == false);
            PlayingField();
            GameResult(isGameLoopOver);
        }
        public static void ArrayInitiation()        //  Initierar alla fält.
        {
            maskedWord = new string[Story.randomWord.Length];
            rightLetters = new string[Story.randomWord.Length];
            wrongLetters = new string[Story.playerLife];
            //  Initierar fälten och lägger in minustecken för varje bokstav i det dolda ordet.
            for (int hiddenLetter = 0; hiddenLetter < Story.randomWord.Length; hiddenLetter++)
            {
                maskedWord[hiddenLetter] = "-";
            }
            //  Initierar fälten för korrekta gissningar.
            for (int hiddenLetter = 0; hiddenLetter < Story.randomWord.Length; hiddenLetter++)
            {
                rightLetters[hiddenLetter] = " ";
            }
            //  Initierar fälten för felaktiga gissningar.
            for (int hiddenLetter = 0; hiddenLetter < Story.playerLife; hiddenLetter++)
            {
                wrongLetters[hiddenLetter] = " ";
            }
        }
        public static string TempString(string[] tempStringArray)
        {
            string tempString = string.Empty;

            for (int i = 0; i < tempStringArray.Length; i++)
            {
                tempString += tempStringArray[i];
            }

            return tempString;
        }
        public static void PlayingField()  //  Ritar upp spelplanen, frågar efter bokstav samt returnerar värde.
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("   Category: " + Story.category);
            Console.WriteLine("----------------------------------");
            Console.Write("\n\tSecret word: ");
            for (int i = 0; i < Story.randomWord.Length; i++)
            {
                Console.Write(maskedWord[i]);
            }
            Console.WriteLine("\n\n----------------------------------");
            Console.Write("\tUsed letters:\n     ");

            for (int i = 0; i < playerGuesses; i++)
            {
                Console.Write(wrongLetters[i] + " ");
            }

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("    You have " + Story.playerLife + " guesses left.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n\n\n----------------------------------");
        }
        public static bool GameEngine()    //  Spelmotor.
        {
            string input;
            string[] usedLetters = new string[Story.randomWord.Length];
            bool isGameWon;
            bool isRightGuess;
            //  Har spelaren liv kvar?
            if (Story.playerLife > 0)
            {
                {
                    //  Ritar upp spelplan och frågar efter bokstav.
                    do
                    {
                        PlayingField();
                        input = GuessLetter();
                    } while (input.Length != 1);
                    isRightGuess = false;
                    //  Finns bokstaven i det dolda ordet?
                    for (int guessedLetter = 0; guessedLetter < Story.randomWord.Length; guessedLetter++)
                    {
                        //  Kollar om bokstaven finns och byter ut minustecken mot denna.
                        if (input[0] == Story.randomWord[guessedLetter])
                        {
                            maskedWord[guessedLetter] = input;
                            isRightGuess = true;
                        }
                    }
                    //  Bokstaven finns inte med i det hemliga ordet.
                    if (!isRightGuess)
                    {
                        //  Kollar om den felaktiga gissningen använts tidigare.
                        for (int guessedLetter = 0; guessedLetter < playerGuesses; guessedLetter++)
                        {
                            if (input == wrongLetters[guessedLetter])
                            {
                                //  Meddelar att gissningen använts tidigare.
                                PlayingField();
                                AlreadyUsedLetter();
                                isRightGuess = true;
                            }
                        }
                        //  Bokstaven är fel men har inte använts tidigare.
                        if (!isRightGuess)
                        {
                            PlayingField();
                            WrongGuess();
                            //  Lagrar gissningen i första fältet för felaktiga gissningar.
                            wrongLetters[wrongGuesses] = input;
                            //  Byter till nästa fält för felaktiga gissningar.
                            wrongGuesses++;
                            //  Räknar ner ett liv.
                            Story.playerLife--;
                        }
                    }
                    //  Bokstaven finns med i det hemliga ordet.
                    else
                    {
                        bool used = false;
                        //  Kollar om den korrekta gissningen har använts tidigare.
                        for (int guessedLetter = 0; guessedLetter < Story.randomWord.Length; guessedLetter++)
                        {
                            if (input == rightLetters[guessedLetter])
                            {
                                used = true;
                            }
                        }
                        //  Bokstaven är korrekt men har inte använts tidigare.
                        if (!used)
                        {
                            PlayingField();
                            RightGuess();
                            //  Lagrar gissningen i första fältet för korrekta gissningar.
                            rightLetters[rightGuesses] = input;
                            //  Byter till nästa fält för korrekta gissningar.
                            rightGuesses++;
                        }
                        else
                        {
                            //  Meddelar att gissningen använts tidigare.
                            PlayingField();
                            AlreadyUsedLetter();
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
            Console.Write("\tGuess a letter: ");
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
                    Program.isGameOver = true;
                    break;
                default:
                    Restart();
                    break;
            }
        }
    }
}
