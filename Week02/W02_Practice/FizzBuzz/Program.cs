using System.Reflection.Metadata.Ecma335;

namespace FuzzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fizz-Buzz project.");
            fizz_buzz1();
            Console.WriteLine(fizz_buzz2(35));
        }

        static void fizz_buzz1()
        {
            int user_input;

            do
            {
                Console.WriteLine("Enter your number: ");
                while (!int.TryParse(Console.ReadLine(), out user_input))
                {
                    Console.WriteLine("This is not a number!");
                }

                if (user_input % 15 == 0) { Console.WriteLine("FizzBuzz"); }
                else if (user_input % 5 == 0) { Console.WriteLine("Buzz"); }
                else if (user_input % 3 == 0) { Console.WriteLine("Fizz"); }
                else { Console.WriteLine(Convert.ToString(user_input)); }
            } while (user_input != 0);
        }

        static string fizz_buzz2(int n)
        {
            string ret = "";
            for (int i = 1; i < n + 1; i++)
            {
                if (i % 15 == 0) { ret += "FizzBuzz "; }
                else if (i % 5 == 0) { ret += "Buzz "; }
                else if (i % 3 == 0) { ret += "Fizz "; }
                else { ret += Convert.ToString(i) + " "; }
            }
            return ret;
        }


    }
}
