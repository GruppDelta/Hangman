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

        public static string currentFirstQuarter = "";
        public static string currentSecondQuarter = "";
        public static string currentThirdQuarter = "";
        public static string currentForthQuarter = "";

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

/*      A split examplegraphics

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
 ╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ║                                                                                                                    ║
 ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
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

        public static void DrawAllPartsOfScreen(string inputFirstQuarter, string inputSecondQuarter, string inputThirdQuarter, string inputForthQuarter)
        {
            Console.Clear();
            Console.Write(inputFirstQuarter);
            Console.Write(inputSecondQuarter);
            Console.Write(inputThirdQuarter);
            Console.Write(inputThirdQuarter);
        }

        public static void UpdateFirstQuarterOfScreen(string inputFirstQuarter)
        {
            Console.Clear();
            Console.Write(inputFirstQuarter);
            Console.Write(currentSecondQuarter);
            Console.Write(currentThirdQuarter);
            Console.Write(currentForthQuarter);
        }

        public static void UpdateSecondQuarterOfScreen(string inputSecondQuarter)
        {
            Console.Clear();
            Console.Write(currentFirstQuarter);
            Console.Write(inputSecondQuarter);
            Console.Write(currentThirdQuarter);
            Console.Write(currentForthQuarter);
        }

        public static void UpdateThirdQuarterOfScreen(string inputThirdQuarter)
        {
            Console.Clear();
            Console.Write(currentFirstQuarter);
            Console.Write(currentSecondQuarter);
            Console.Write(inputThirdQuarter);
            Console.Write(currentForthQuarter);
        }

        public static void UpdateForthQuarterOfScreen(string inputForthQuarter)
        {
            Console.Clear();
            Console.Write(currentFirstQuarter);
            Console.Write(currentSecondQuarter);
            Console.Write(currentThirdQuarter);
            Console.Write(inputForthQuarter);
        }

        #endregion
    }
}
