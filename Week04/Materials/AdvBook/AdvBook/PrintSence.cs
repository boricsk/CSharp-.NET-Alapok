using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBook
{
    public static class PrintSences
    {
        public static void PrintSence(Possibility possibility, Player player, string title)
        {
            Console.Clear();
            Console.WriteLine($"{player.Name} | HP: {player.Health} | Story : {title}");
            Console.WriteLine(possibility.Title);
            Console.WriteLine();
            Console.WriteLine(possibility.Text);
            Console.WriteLine("\nVálassz!");
        }
    }
}
