using System;

namespace BatalhaNaval
{
    public class Game
    {
        public static void Interface() {
            Random rnd = new Random();
            Player player = new Player();
            Settings.Menu();
            Settings.InicializarGrelha();
            int coluna;
            int linha;
            int boats = 5;
            int coord1;
            int coord2;
            player.Score = 0;

            for (int i = 0; i < 5; i++)
            {
                coord1 = rnd.Next(6);
                coord2 = rnd.Next(6);

                Settings.grelha[coord1, coord2] = 2;
            }

            do
            {
                Console.Clear();
                Settings.Menu();
                Console.SetCursorPosition(23, 9);
                Console.Write("Jogador: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(player.Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(23, 10);
                Console.Write("Pontos: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(player.Score);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(10, 6);
                Console.Write("1 2 3 4 5 6 ");
                Console.SetCursorPosition(8, 7);
                Console.Write("1");
                Console.SetCursorPosition(8, 8);
                Console.Write("2");
                Console.SetCursorPosition(8, 9);
                Console.Write("3");
                Console.SetCursorPosition(8, 10);
                Console.Write("4");
                Console.SetCursorPosition(8, 11);
                Console.Write("5");
                Console.SetCursorPosition(8, 12);
                Console.Write("6");
                Settings.DesenharGrelha();
                Console.SetCursorPosition(1, 16);
                Console.WriteLine("Insira a coordenada linha,coluna do tiro (exemplo: 1,1)");
                Console.SetCursorPosition(1, 17);
                Console.Write("> ");
                
                /* Coords[0] = linha
                 * Coords [1] = coluna
                 * String split é para dividir a linha e a coluna com uma virgula
                 */ 
                var coords = Console.ReadLine().Trim().Split(',');
                
                if (coords[0] == "d")
                {
                    Environment.Exit(0);
                }
                
                if (Int32.TryParse(coords[0], out linha))
                {
                    if (linha >= 1 && linha <= 6)
                    {
                        if (Int32.TryParse(coords[1], out coluna))
                        {
                            if ((coluna >= 1) && (coluna <= 6))
                            {
                                if (Settings.grelha[coluna - 1, linha - 1] == 2)
                                {
                                    boats--;
                                    ++player.Score;
                                    Console.SetCursorPosition(8, 14);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Acertou no alvo: navio inimigo");
                                    Console.ReadKey();
                                    Settings.grelha[coluna - 1, linha - 1] = 3;
                                }
                                else
                                {
                                    if (player.Score == 0)
                                    {
                                        player.Score = 0;
                                    }
                                    else
                                    {
                                        --player.Score;
                                    }

                                    Console.SetCursorPosition(8, 14);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Falhou o alvo: acertou na água");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Settings.grelha[coluna, linha] = 1;
                                    Console.ReadKey();

                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(1, 17);
                                Console.Write("Inseriu um número inválido, use d para desistir ou coordenada no formato linha,coluna");
                                Console.SetCursorPosition(1, 18);
                                Console.WriteLine("Pressione qualquer tecla para novas coordenadas...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadKey();
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(1, 17);
                            Console.Write("Inseriu um número inválido, use d para desistir ou coordenada no formato linha,coluna");
                            Console.SetCursorPosition(1, 18);
                            Console.WriteLine("Pressione qualquer tecla para novas coordenadas...");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(1, 17);
                        Console.Write("Inseriu um número inválido, use d para desistir ou coordenada no formato linha,coluna");
                        Console.SetCursorPosition(1, 18);
                        Console.WriteLine("Pressione qualquer tecla para novas coordenadas...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(1, 17);
                    Console.Write("Inseriu um número inválido, use d para desistir ou coordenada no formato linha,coluna");
                    Console.SetCursorPosition(1, 18);
                    Console.WriteLine("Pressione qualquer tecla para novas coordenadas...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
            } while (boats > 0);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Parabéns");
            Console.ReadKey();
        }
    }
}