using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class GFX
    {
        #region Class Variables

        public static string currentTopBox = "";
        public static string currentMiddleBox = "";
        //public static string currentRightBox = "";
        public static string currentBottomBox = "";

        public enum BoxPos : int { TopBoxLeft = 0, TopBoxTop = 0, MiddleBoxLeft = 0, MiddleBoxTop = 20, BottomBoxLeft = 0, BottomBoxTop = 24, BottomBoxWritingLeft = 26, BottomBoxWritingTop = 26 };

        #endregion

        #region Example Graphics

        /*      A full screen template covering top to bottom. Used for only showing graphics without asking for input.

        WhateverFunction(
        @" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
        ");

        */

        /*      Almost a fullscreen. Leaving one line at the bottom. Good for asking for input.

        WhateverFunction(
        @" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ║                                                                                                                    ║
         ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
        ");

        */

        /*      A split examplegraphics.

        WhateverFunction(
        @" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
         ║                                                                                                                     ║ 
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ╠══════════════════════════════════════════════════════╦══════════════════════════════════════════════════════════════╣
         ║                                                      ║                                                              ║
         ║                                                      ║                                                              ║
         ║                                                      ║                                                              ║
         ╠══════════════════════════════════════════════════════╩══════════════════════════════════════════════════════════════╣
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ║                                                                                                                     ║
         ╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
        ");

        */

        #endregion

        #region FullScreen Graphics

        public static void WelcomeGFX()                //  Välkomstgrafik; Delta Squad Entertainment
        {
            DrawFullScreen(
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
 ║                                                                                                                    ║
 ║ ██████╗ ███████╗██╗  ████████╗ █████╗     ███████╗ ██████╗ ██╗   ██╗ █████╗ ██████╗ TM                             ║
 ║ ██╔══██╗██╔════╝██║  ╚══██╔══╝██╔══██╗    ██╔════╝██╔═══██╗██║   ██║██╔══██╗██╔══██╗                               ║
 ║ ██║  ██║█████╗  ██║     ██║   ███████║    ███████╗██║   ██║██║   ██║███████║██║  ██║                               ║
 ║ ██║  ██║██╔══╝  ██║     ██║   ██╔══██║    ╚════██║██║▄▄ ██║██║   ██║██╔══██║██║  ██║                               ║
 ║ ██████╔╝███████╗███████╗██║   ██║  ██║    ███████║╚██████╔╝╚██████╔╝██║  ██║██████╔╝                               ║
 ║ ╚═════╝ ╚══════╝╚══════╝╚═╝   ╚═╝  ╚═╝    ╚══════╝ ╚══▀▀═╝  ╚═════╝ ╚═╝  ╚═╝╚═════╝                                ║
 ║                                                                                                                    ║
 ║ ███████╗███╗   ██╗████████╗███████╗██████╗ ████████╗ █████╗ ██╗███╗   ██╗███╗   ███╗███████╗███╗   ██╗████████╗    ║
 ║ ██╔════╝████╗  ██║╚══██╔══╝██╔════╝██╔══██╗╚══██╔══╝██╔══██╗██║████╗  ██║████╗ ████║██╔════╝████╗  ██║╚══██╔══╝    ║
 ║ █████╗  ██╔██╗ ██║   ██║   █████╗  ██████╔╝   ██║   ███████║██║██╔██╗ ██║██╔████╔██║█████╗  ██╔██╗ ██║   ██║       ║
 ║ ██╔══╝  ██║╚██╗██║   ██║   ██╔══╝  ██╔══██╗   ██║   ██╔══██║██║██║╚██╗██║██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║       ║
 ║ ███████╗██║ ╚████║   ██║   ███████╗██║  ██║   ██║   ██║  ██║██║██║ ╚████║██║ ╚═╝ ██║███████╗██║ ╚████║   ██║       ║
 ║ ╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝       ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║ ██████╗ ██████╗ ███████╗███████╗███████╗███╗   ██╗████████╗███████╗                                                ║
 ║ ██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝████╗  ██║╚══██╔══╝██╔════╝                                                ║
 ║ ██████╔╝██████╔╝█████╗  ███████╗█████╗  ██╔██╗ ██║   ██║   ███████╗                                                ║
 ║ ██╔═══╝ ██╔══██╗██╔══╝  ╚════██║██╔══╝  ██║╚██╗██║   ██║   ╚════██║                                                ║
 ║ ██║     ██║  ██║███████╗███████║███████╗██║ ╚████║   ██║   ███████║                                                ║
 ║ ╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝                                                ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
"); //Important to end the string on a new line.
        }

        public static void PlayerGFX()
        {
            DrawFullScreen(
@" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                      ██░ ██  ▄▄▄       ███▄    █   ▄████  ███▄ ▄███▓ ▄▄▄       ███▄    █                           ║
 ║                     ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓██▒▀█▀ ██▒▒████▄     ██ ▀█   █                           ║
 ║                     ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▓██    ▓██░▒██  ▀█▄  ▓██  ▀█ ██▒                          ║
 ║                     ░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒██    ▒██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒                          ║
 ║                     ░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒▒██▒   ░██▒ ▓█   ▓██▒▒██░   ▓██░                          ║
 ║                      ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░ ▒░   ░  ░ ▒▒   ▓▒█░░ ▒░   ▒ ▒                           ║
 ║                     ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░ ░  ░      ░  ▒   ▒▒ ░░ ░░   ░ ▒░                           ║
 ║                      ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░ ░      ░     ░   ▒      ░   ░ ░                           ║
 ║                     ░  ░  ░      ░  ░         ░       ░        ░         ░  ░         ░                            ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                    ENTER THE NAME OF THE FOOLISH MORTAL WHO DARES ATTEMPT THIS GAME                                ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
"); //Important to end the string on a new line.
        }

        #endregion

        #region Drawing Methods

        public static void DrawFullScreen(string inputString)
        {
            Console.Clear();
            Console.Write(inputString);
        }

        public static void DrawTestScreen()
        {
            Console.Clear();
            Console.Write(FormatTopBox(Story.EasyGraphics(10)));
            Console.Write(FormatMiddleBox("N_TION_LENCYKLOPEDIN", "ASDFASDF"));
            Console.Write(FormatBottomBox(""));
        }
        public static void DrawAllPartsOfScreen()
        {
            Console.Clear();
            Console.Write(currentTopBox);
            Console.Write(currentMiddleBox);
            Console.Write(currentBottomBox);
        }

        public static string FormatTopBox(string inputTopBox) //Redundant at the moment. Included for completeness.
        {
            Console.SetCursorPosition((int)BoxPos.TopBoxLeft, (int)BoxPos.TopBoxTop);

            if (inputTopBox != "")
            {
                currentTopBox = inputTopBox;
                return inputTopBox;
            }

            string tempSpaceLine = "                                                                                                                    ";

            string tempTopBoxString = FormatSpacesWithCenteredWord(tempSpaceLine, inputTopBox);

            string tempString = "" +
" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n" +
" ║                                                                                                                    ║\n";

            currentTopBox = tempString;

            return tempString;
        }

        public static string FormatMiddleBox(string inputLeftBox, string inputRightBox) // Takes a string of guessed letters.
        {
            Console.SetCursorPosition((int)BoxPos.MiddleBoxLeft, (int)BoxPos.MiddleBoxTop);

            string leftBoxSpaceString  = "                                                         ";
            string rightBoxSpaceString = "                                                          ";

            string leftBoxTempString = FormatSpacesWithCenteredWord(leftBoxSpaceString, inputLeftBox);
            string rightBoxTempString = FormatSpacesWithCenteredWord(rightBoxSpaceString, inputRightBox);


            string tempString = "" +
" ╠═════════════════════════════════════════════════════════╦══════════════════════════════════════════════════════════╣\n" +
" ║                                                         ║                                                          ║\n" +
" ║" + leftBoxTempString + "║" + rightBoxTempString + "║\n" +
" ║                                                         ║                                                          ║\n";

            currentMiddleBox = tempString;
            return tempString;
        }

        public static string FormatBottomBox(string inputBottomBox) // Area to write and guess.
        {
            Console.SetCursorPosition((int)BoxPos.BottomBoxLeft, (int)BoxPos.BottomBoxTop);

            string spaceString = "                                                                                                                    ";

            string noteToUserString = FormatSpacesWithCenteredWord(spaceString, inputBottomBox);

            string tempString = "" +
" ╠═════════════════════════════════════════════════════════╩══════════════════════════════════════════════════════════╣" + Environment.NewLine +
" ║" + noteToUserString +"║" + Environment.NewLine +
" ║        Guess a letter:                                                                                             ║" + Environment.NewLine +
" ║                                                                                                                    ║" + Environment.NewLine +
" ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝";
            currentBottomBox = tempString;

            Console.SetCursorPosition((int)BoxPos.BottomBoxLeft, (int)BoxPos.BottomBoxTop);

            return tempString;
        }

        private static string FormatSpacesWithCenteredWord(string inputSpaceString, string inputWordString)
        {

            char[] tempTopBoxCharArray = new char[inputSpaceString.Length];

            for (int i = (tempTopBoxCharArray.Length / 2) - (inputWordString.Length / 2), j = 0; j < inputWordString.Length; i++, j++)
            {
                tempTopBoxCharArray[i - 1] = inputWordString[j];
            }
            
            return new string (tempTopBoxCharArray);
        }

        public static void UpdateTopBoxOfScreen(string inputTopBox)
        {
            Console.Clear();
            Console.Write(inputTopBox);
            Console.Write(currentMiddleBox);
            Console.Write(currentBottomBox);
        }

        public static void UpdateMiddleBoxOfScreen(string inputMiddleBox)
        {
            Console.Clear();
            Console.Write(currentTopBox);
            Console.Write(inputMiddleBox);
            Console.Write(currentBottomBox);
        }

        public static void UpdateRightBoxOfScreen(string inputRightBox)
        {
            Console.Clear();
            Console.Write(currentTopBox);
            Console.Write(currentMiddleBox);
            Console.Write(currentBottomBox);
        }

        public static void UpdateBottomBoxOfScreen(string inputBottomBox)
        {
            Console.Clear();
            Console.Write(currentTopBox);
            Console.Write(currentMiddleBox);
            Console.Write(inputBottomBox);
        }

        #endregion
    }
}
