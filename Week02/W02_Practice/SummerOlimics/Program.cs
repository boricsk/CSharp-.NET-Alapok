namespace SummerOlimics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Summer Olimpics project");
            Console.WriteLine($"{were_summer_olimpics(get_year())}");
        }

        static bool were_summer_olimpics(int year)
        {
            return (year == 2021 || year >= 1896 && year <= 2025 && year % 4 == 0 && year != 1916 && year != 1940 && year != 1944);
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
