using System.Reflection.Metadata.Ecma335;

namespace Pract_Primek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_prime(5));
            sieve(7920);
            determine_n(1000);
        }

        static bool is_prime(int n)
        {
            int i = 2;
            do
            {
                if (n % i == 0) { return false; }
                i++;
            } while (i * i <= n);
            return true;
        }

        static void sieve(int n)
        {
            bool[] prime_list = new bool[n + 1];
            for (int i = 0; i < prime_list.Length; i++)
            {
                prime_list[i] = true;
            }
            prime_list[0] = false;
            prime_list[1] = false;
            //elballagunk az n gyökéig + 1
            for (var i = 2; i * i <= n; i++)
            {
                //végigballagunk a listán úgy, hogy be tudjuk állítani i többszöröseire a false-t
                for (var j = 2 * i; j <= n; j += i)
                {
                    prime_list[j] = false;
                }
            }
            List<int> primes = new List<int>();
            for (var k = 0; k < prime_list.Length; k++)
            {
                if (prime_list[k])
                {
                    Console.Write($"{k} ");
                    primes.Add(k);

                }
            }
            Console.WriteLine();
            Console.WriteLine($"Primek száma : {primes.Count}");
        }

        static void determine_n(int number_of_primes)
        {
            List<int> primes = new List<int>();
            int i = 0;
            do
            {
                if (is_prime(i)) { primes.Add(i); }
                i++;
            } while (primes.Count < number_of_primes);
            Console.WriteLine($"Iteration number is {i}");
        }
    }
}
