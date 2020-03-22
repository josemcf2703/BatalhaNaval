using System;

namespace BatalhaNaval
{
    public class Settings
    {
        public static void Menu() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("───────────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("|                                                                                         |");
            Console.ForegroundColor = ConsoleColor.Yellow;                
            Console.WriteLine("| B A T A L H A   N A V A L  (Versão Light)                                               |");
            Console.ForegroundColor = ConsoleColor.White;                
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("|                                                                                         |");
            Console.WriteLine("───────────────────────────────────────────────────────────────────────────────────────────");
        }
        public static int[,] grelha = new int[6, 6];
        
        public static void InicializarGrelha()
        {
            for (int i = 0; i < grelha.GetLength(0); ++i)
            {
                for (int j = 0; j < grelha.GetLength(1); ++j)
                {
                    grelha[i, j] = 0;
                }
            }
        }
        public static void DesenharGrelha()
        {
            int y = 7;

            for (int l = 0; l < grelha.GetLength(0); ++l)
            {
                Console.SetCursorPosition(10, y);

                for (int c = 0; c < grelha.GetLength(1); ++c)
                {
                    // Mar
                    if (grelha[l, c] == 0)
                    {
                        Console.Write(". ");
                    }
                    //Barcos
                    else if (grelha[l, c] == 2)
                    {
                        Console.Write(". ");
                    }
                    //Mar com tiro
                    else if (grelha[l, c] == 1)
                    {

                        Console.Write("X ");
                    }
                    //Barcos com tiro
                    else if (grelha[l, c] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("X ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                y++;
            }
        }
    }
}