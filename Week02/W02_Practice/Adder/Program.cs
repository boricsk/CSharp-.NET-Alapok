namespace adder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the adder project");
            adder();
        }

        static void adder()
        {
            int user_input;
            int res = 0;
            do
            {
                Console.WriteLine("Enter your number (0 -> Exit) : ");
                while (!int.TryParse(Console.ReadLine(), out user_input))
                {
                    Console.WriteLine("This is not a number!");
                }
                Console.WriteLine($"Result : {res += user_input}");

            } while (user_input != 0);
        }
    }
}
