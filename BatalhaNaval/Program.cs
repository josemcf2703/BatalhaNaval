using System;

namespace BatalhaNaval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Batalha Naval");
            Console.WriteLine();
            Console.Write("Nome: ");
            player.Name = Console.ReadLine();
            Console.Write("Jogo(Simples ou ...): ");
            string jogo = Console.ReadLine();
            if (jogo == "Simples")
                Game.Interface(player);
            else
                Console.WriteLine("Desenvolvimento");
        }
    }
}