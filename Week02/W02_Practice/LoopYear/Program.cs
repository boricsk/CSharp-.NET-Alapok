namespace LoopYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the loop year project");
            Console.WriteLine($"{is_loopyerar(get_year())}");
        }

        static bool is_loopyerar(int year)
        {
            if (year % 4 != 0) { return false; }
            else if (year % 400 == 0) { return true; }
            else if (year % 100 == 0) { return false; }
            else { return true; }
        }

        static int get_year()
        {
            int year = 0;
            Console.WriteLine("Enter the year");
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("This is not a number!");
            }
            return year;
        }
    }
}
