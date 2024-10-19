using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBook
{
    public static class Progress
    {
        static string ProgressBar(int progress, int total)
        {
            int progressBarWidth = 40;
            int progressPosition = (int)((double)progress / total * progressBarWidth);

            string completed = new string('#', progressPosition);
            string remaining = new string('-', progressBarWidth - progressPosition);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(completed);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(remaining);

            return "";
        }

        public static void PrintProgress(string caption)
        {
            int total = 100;

            for (int i = 0; i <= total; i++)
            {
                Console.Write($"\r{caption}: {i}% {ProgressBar(i, total)}");
                Thread.Sleep(20); //Tentikél 20 milisec-ig
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nKész!");
            Console.ResetColor();
        }
    }
}
