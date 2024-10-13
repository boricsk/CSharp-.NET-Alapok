using System.Diagnostics;
namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Prime project.");

            List<int> intervall = get_intervall();
            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();
            Console.WriteLine("Illés's algorithm");
            Console.WriteLine($"Number of primes in intervall [{intervall[0]} - {intervall[1]}] is {count_prime_numbers_2(intervall[0], intervall[1])} pc.");
            stopwatch.Stop();
            Console.WriteLine($"Run time [ms] {stopwatch.ElapsedMilliseconds}");
            
            Console.WriteLine();
            stopwatch.Restart();
            
            stopwatch.Start();
            Console.WriteLine("My algorithm");
            Console.WriteLine($"Number of primes in intervall [{intervall[0]} - {intervall[1]}] is {count_prime_numbers_1(intervall[0], intervall[1])} pc.");
            stopwatch.Stop();
            
            Console.WriteLine($"Run time [ms] {stopwatch.ElapsedMilliseconds}");
        }

        static List<int> get_intervall()
        {
            int start = 0;
            int end = 0;
            List<int> intervall = new List<int>();
            do
            {
                Console.WriteLine("Enter start of your intervall: ");
                while (!int.TryParse(Console.ReadLine(), out start))
                {
                    Console.WriteLine("This is not a number!");
                }

                Console.WriteLine("Enter end of your intervall: ");
                while (!int.TryParse(Console.ReadLine(), out end))
                {
                    Console.WriteLine("This is not a number!");
                }
                if (start > end) { Console.WriteLine("Wrong intervall."); }
            } while (start > end);
            intervall.Add(start);
            intervall.Add(end);
            return intervall;
        }

        static int count_prime_numbers_1(int start, int end)
        {
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                //Console.WriteLine($"Is {i} prime ? : {is_prime(i)}");
                if (is_prime(i)) { count++; }
                //if (is_prime_tanarur(i)) { count++; }
            }
            return count;
        }

        static int count_prime_numbers_2(int start, int end) 
        {
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                //Console.WriteLine($"Is {i} prime ? : {is_prime(i)}");
                //if (is_prime(i)) { count++; }
                if (is_prime_tanarur(i)) { count++; }

            }
            return count;
            
        }

        static bool is_prime(int n)
        {
            if (n < 2) { return false; } else if (n == 2) { return true; }
            int i = 2;
            do
            {
                if (n % i == 0) { return false; }
                i++;
            } while (i * i <= n);
            return true;
        }

        static bool is_prime_tanarur(int n)
        {
            if (n < 2) return false;
            return Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i != 0);
        }
    }
}
