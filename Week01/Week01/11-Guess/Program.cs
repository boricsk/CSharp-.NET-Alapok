namespace _11_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random  rnd = new Random();
            int gn = rnd.Next(1,100);
            int guesses = 0;
            do
            {
                Console.WriteLine("Guess the number");
                guesses++;
            } while (!Process(Guess1(), gn));
            Console.WriteLine($"Number of your guess : {guesses}");
        }

        static int Guess1()
        {
            int yg;
            while (!int.TryParse(Console.ReadLine(), out yg))
            {
                Console.WriteLine("This is not a number");
            }
            return yg;
        }

        static bool Process(int yg, int gn)
        {
            if (yg < gn)
            {
                Console.WriteLine("Higher");
            }
            else if (yg > gn)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Win!");
                return true;
            }
            return false;
        }
    }
}
