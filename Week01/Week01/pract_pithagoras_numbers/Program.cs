namespace pract_pithagoras_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            pitagoras_harmasok(400);
        }
        static void pitagoras_harmasok(int max)
        {
            Console.WriteLine($"Pitagoraszi hármasok {max} -ig");
            Console.WriteLine();
            for (int i = 1; i < max + 1; i++)
            {
                for (int j = i; j < max + 1; j++)
                {
                    for (int k = j; k < max + 1; k++)
                    {
                        if (i * i + j * j == k * k) { Console.WriteLine($"{i}, {j}, {k}"); }
                    }
                }
            }
        }
    }
}
