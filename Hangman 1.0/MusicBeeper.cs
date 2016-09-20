using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class MusicBeeper
    {
        //En variabel som styr bpm. Öka den här och allt går snabbare. Minska och allt går långsammare.
        public static double bpm = 120.0;

        //Rör inte den här. Den gör matte.
        public static int musicRate = (int)((60.0 / bpm) * 1000);

        //Här är typ "namn" för vanliga grejer jag använder i programmet. Istället för att ha i huvudet att varje gång jag skriver 0.25 så menar jag en fjärdedelsnot. Så gjorde jag en namnlista med dem typ.
        public struct Music
        {
            public static double fullNote = 1.000;
            public static double halfNote = 0.500;
            public static double quarterNote = 0.250;
            public static double eigthNote = 0.125;
            public static double sixteenthNote = 0.625;
            public static double thirtyecondthNote = 0.03125;

        }

        //Det här är bara arrayer med alla frekvenser till alla noter. Då kan jag skriva c[4] för att mena till programmet att jag vill göra ljudet i 261.6 hz.
        public struct Note
        {
            public static double[] c = { 16.35, 32.70, 65.41, 130.8, 261.6, 523.3, 1047, 2093, 4186 };
            public static double[] csharp = { 17.32, 34.65, 69.30, 138.6, 277.2, 554.4, 1109, 2217, 4435 };
            public static double[] d = { 18.35, 36.71, 73.42, 146.8, 293.7, 587.3, 1175, 2349, 4699 };
            public static double[] eflat = { 19.45, 38.89, 77.78, 155.6, 311.1, 622.3, 1245, 2489, 4978 };
            public static double[] e = { 20.60, 41.20, 82.41, 164.8, 329.6, 659.3, 1319, 2637, 5274 };
            public static double[] f = { 21.83, 43.65, 87.31, 174.6, 349.2, 698.5, 1397, 2794, 5588 };
            public static double[] fsharp = { 23.12, 46.25, 92.50, 185.0, 370.0, 740.0, 1480, 2960, 5920 };
            public static double[] g = { 24.50, 49.00, 98.00, 196.0, 392.0, 784.0, 1568, 3136, 6272 };
            public static double[] gsharp = { 25.96, 51.91, 103.8, 207.7, 415.3, 830.6, 1661, 3322, 6645 };
            public static double[] a = { 27.50, 55.00, 110.0, 220.0, 440.0, 880.0, 1760, 3520, 7040 };
            public static double[] bflat = { 29.14, 58.27, 116.5, 233.1, 466.2, 932.3, 1865, 3729, 7459 };
            public static double[] b = { 30.87, 61.74, 123.5, 246.9, 493.9, 987.8, 1976, 3951, 7902 };
        }


        //Jag tyckte koden blev så grötig av att skriva 
        //System.Console.Beep((int)Note.e[3], ((int)Music.quarterNote * musicRate));
        //Så jag gjorde en metod som gömmer undan allt det grötiga och kallar på dem med de två saker jag behöver använda varje gång. D.v.s vilken not som ska spelas och hur länge den ska låta.
        public static void BetterBeep(double note, double length)
        {
            System.Console.Beep((int)note, (int)(length * musicRate));
        }

        //Här börjar musikloopen. När man väl är här inne kommer man inte ur förrän main säger åt tråden att göra abort.
        public static void MusicLoop()
        {
            while (true)
            {

                BetterBeep(Note.e[3], Music.halfNote);
                BetterBeep(Note.e[4], Music.halfNote);

                BetterBeep(Note.e[3], Music.halfNote);
                BetterBeep(Note.fsharp[4], Music.halfNote);

                BetterBeep(Note.e[3], Music.halfNote);
                BetterBeep(Note.g[4], Music.halfNote);

                BetterBeep(Note.e[3], Music.halfNote);
                BetterBeep(Note.a[4], Music.halfNote);

                BetterBeep(Note.e[3], Music.halfNote);
                BetterBeep(Note.e[4], Music.halfNote);

                BetterBeep(Note.e[3], Music.halfNote);
                BetterBeep(Note.fsharp[4], Music.halfNote);

                BetterBeep(Note.e[3], Music.halfNote);
                BetterBeep(Note.g[4], Music.halfNote);

                BetterBeep(Note.e[3], Music.halfNote);
                BetterBeep(Note.a[4], Music.halfNote);

                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.fsharp[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);

                BetterBeep(Note.b[4], Music.quarterNote);
                BetterBeep(Note.a[4], Music.quarterNote);
                BetterBeep(Note.c[4], Music.quarterNote);
                BetterBeep(Note.e[4], Music.quarterNote);

                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.fsharp[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);

                BetterBeep(Note.b[4], Music.quarterNote);
                BetterBeep(Note.a[4], Music.quarterNote);
                BetterBeep(Note.c[4], Music.quarterNote);
                BetterBeep(Note.d[4], Music.quarterNote);

                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.fsharp[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);

                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.g[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);

                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.a[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);

                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.b[4], Music.quarterNote);
                BetterBeep(Note.a[4], Music.quarterNote);

                BetterBeep(Note.c[4], Music.quarterNote);
                BetterBeep(Note.e[4], Music.quarterNote);
                BetterBeep(Note.e[4], Music.quarterNote);
                BetterBeep(Note.e[4], Music.quarterNote);

                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.b[3], Music.quarterNote);
                BetterBeep(Note.b[3], Music.quarterNote);
                BetterBeep(Note.g[3], Music.quarterNote);

                BetterBeep(Note.fsharp[3], Music.halfNote);
                BetterBeep(Note.e[3], Music.quarterNote);
                BetterBeep(Note.e[3], Music.quarterNote);

                BetterBeep(Note.fsharp[3], Music.halfNote);
                BetterBeep(Note.e[3], Music.halfNote);

                BetterBeep(Note.g[3], Music.quarterNote);
                BetterBeep(Note.b[3], Music.quarterNote);
                BetterBeep(Note.b[3], Music.quarterNote);
                BetterBeep(Note.e[4], Music.quarterNote);

                BetterBeep(Note.b[4], Music.quarterNote);
                BetterBeep(Note.fsharp[4], Music.quarterNote);
                BetterBeep(Note.g[4], Music.quarterNote);
                BetterBeep(Note.a[4], Music.quarterNote);

                BetterBeep(Note.e[4], Music.quarterNote);
                BetterBeep(Note.b[3], Music.quarterNote);
                BetterBeep(Note.g[3], Music.quarterNote);
                BetterBeep(Note.a[3], Music.quarterNote);

            }
        }
    }
}
