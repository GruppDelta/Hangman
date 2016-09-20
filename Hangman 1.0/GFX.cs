using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_1._0
{
    class GFX
    {
        public static void WelcomeGFX()                //  Välkomstgrafik; Delta Squad Entertainment
        {
            Console.Clear();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║ ██████╗ ███████╗██╗  ████████╗ █████╗     ███████╗ ██████╗ ██╗   ██╗ █████╗ ██████╗ TM                             ║");
            Console.WriteLine(" ║ ██╔══██╗██╔════╝██║  ╚══██╔══╝██╔══██╗    ██╔════╝██╔═══██╗██║   ██║██╔══██╗██╔══██╗                               ║");
            Console.WriteLine(" ║ ██║  ██║█████╗  ██║     ██║   ███████║    ███████╗██║   ██║██║   ██║███████║██║  ██║                               ║");
            Console.WriteLine(" ║ ██║  ██║██╔══╝  ██║     ██║   ██╔══██║    ╚════██║██║▄▄ ██║██║   ██║██╔══██║██║  ██║                               ║");
            Console.WriteLine(" ║ ██████╔╝███████╗███████╗██║   ██║  ██║    ███████║╚██████╔╝╚██████╔╝██║  ██║██████╔╝                               ║");
            Console.WriteLine(" ║ ╚═════╝ ╚══════╝╚══════╝╚═╝   ╚═╝  ╚═╝    ╚══════╝ ╚══▀▀═╝  ╚═════╝ ╚═╝  ╚═╝╚═════╝                                ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║ ███████╗███╗   ██╗████████╗███████╗██████╗ ████████╗ █████╗ ██╗███╗   ██╗███╗   ███╗███████╗███╗   ██╗████████╗    ║");
            Console.WriteLine(" ║ ██╔════╝████╗  ██║╚══██╔══╝██╔════╝██╔══██╗╚══██╔══╝██╔══██╗██║████╗  ██║████╗ ████║██╔════╝████╗  ██║╚══██╔══╝    ║");
            Console.WriteLine(" ║ █████╗  ██╔██╗ ██║   ██║   █████╗  ██████╔╝   ██║   ███████║██║██╔██╗ ██║██╔████╔██║█████╗  ██╔██╗ ██║   ██║       ║");
            Console.WriteLine(" ║ ██╔══╝  ██║╚██╗██║   ██║   ██╔══╝  ██╔══██╗   ██║   ██╔══██║██║██║╚██╗██║██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║       ║");
            Console.WriteLine(" ║ ███████╗██║ ╚████║   ██║   ███████╗██║  ██║   ██║   ██║  ██║██║██║ ╚████║██║ ╚═╝ ██║███████╗██║ ╚████║   ██║       ║");
            Console.WriteLine(" ║ ╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝       ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║ ██████╗ ██████╗ ███████╗███████╗███████╗███╗   ██╗████████╗███████╗                                                ║");
            Console.WriteLine(" ║ ██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝████╗  ██║╚══██╔══╝██╔════╝                                                ║");
            Console.WriteLine(" ║ ██████╔╝██████╔╝█████╗  ███████╗█████╗  ██╔██╗ ██║   ██║   ███████╗                                                ║");
            Console.WriteLine(" ║ ██╔═══╝ ██╔══██╗██╔══╝  ╚════██║██╔══╝  ██║╚██╗██║   ██║   ╚════██║                                                ║");
            Console.WriteLine(" ║ ██║     ██║  ██║███████╗███████║███████╗██║ ╚████║   ██║   ███████║                                                ║");
            Console.WriteLine(" ║ ╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝                                                ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ║                                                                                                                    ║");
            Console.WriteLine(" ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
        public static void PlayerGFX()                //  Namninmatning och test av stränglängd
            {
                Console.Clear();
                Console.WriteLine(" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                      ██░ ██  ▄▄▄       ███▄    █   ▄████  ███▄ ▄███▓ ▄▄▄       ███▄    █                           ║");
                Console.WriteLine(" ║                     ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓██▒▀█▀ ██▒▒████▄     ██ ▀█   █                           ║");
                Console.WriteLine(" ║                     ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▓██    ▓██░▒██  ▀█▄  ▓██  ▀█ ██▒                          ║");
                Console.WriteLine(" ║                     ░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒██    ▒██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒                          ║");
                Console.WriteLine(" ║                     ░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒▒██▒   ░██▒ ▓█   ▓██▒▒██░   ▓██░                          ║");
                Console.WriteLine(" ║                      ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░ ▒░   ░  ░ ▒▒   ▓▒█░░ ▒░   ▒ ▒                           ║");
                Console.WriteLine(" ║                     ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░ ░  ░      ░  ▒   ▒▒ ░░ ░░   ░ ▒░                           ║");
                Console.WriteLine(" ║                      ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░ ░      ░     ░   ▒      ░   ░ ░                           ║");
                Console.WriteLine(" ║                     ░  ░  ░      ░  ░         ░       ░        ░         ░  ░         ░                            ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                    ENTER THE NAME OF THE FOOLISH MORTAL WHO DARES ATTEMPT THIS GAME                                ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ║                                                                                                                    ║");
                Console.WriteLine(" ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}
