using System.Reflection.Metadata.Ecma335;

namespace HW_MasterMind
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<char> guess = new List<char>();
            List<char> puzzle = new List<char>();
            puzzle = generate_puzzle();
            int count = 0;
            do
            {
                count++;
            } while (!game_engine(puzzle, user_guess()));
            Console.WriteLine($"Number of your guess is : {count}");
        }

        static List<char> generate_puzzle()
        {
            List<char> puzzle_list = new List<char>();
            Random rnd = new Random();
            string string_puzzle = rnd.Next(1, 1000).ToString("D3");
            foreach (char c in string_puzzle)
            {
                puzzle_list.Add(c);
            }
            
            return puzzle_list;
        }

        static List<char> user_guess()
        {
            int user_guess_int = 0;
            List<char> guess_list = new List<char>();
            Console.WriteLine("Enter your guess : ");
            while (!int.TryParse(Console.ReadLine(), out user_guess_int) || (user_guess_int <= 0 || user_guess_int >=1000))
            {
                Console.WriteLine("This is not a number or the number is not in 0-1000 intervall.");
                Console.WriteLine("Enter your guess : ");
            }
            string user_guess = user_guess_int.ToString("D3");
            foreach (char c in user_guess)
            {
                guess_list.Add(c);
            }
            return guess_list;
        }

        static bool game_engine(List<char> puzzle, List<char> guess)
        {
            //bool ret = false;
            if ((puzzle[0] == guess[0]) && (puzzle[1] == guess[1]) && (puzzle[2] == guess[2]))
            {
                Console.WriteLine("Congratulation! You won!");
                return true;
            }
            else
            {
                for (int i = 0; i <= 2; i++)
                {
                    if ((int)puzzle[i] > (int)guess[i]) { Console.WriteLine($"{1+i} digit is higher."); }
                    if ((int)puzzle[i] < (int)guess[i]) { Console.WriteLine($"{1+i} digit is lower."); }
                }
                //if ((int)puzzle[1] > (int)guess[1]) { Console.WriteLine("Second digit is higher."); }
                //if ((int)puzzle[1] < (int)guess[1]) { Console.WriteLine("Second digit is lower."); }
                //if ((int)puzzle[2] > (int)guess[2]) { Console.WriteLine("Third digit is higher."); }
                //if ((int)puzzle[2] < (int)guess[2]) { Console.WriteLine("Third digit is lower."); }
                return false;
            }            
        }
    }
}
