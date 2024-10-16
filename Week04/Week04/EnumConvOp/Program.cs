namespace EnumConvOp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            foreach (ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = item;
                Console.WriteLine("Hello, World!");
            }

            for (int i = 0; i < 14; i++)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine("Hello, World!");
            }
        }
    }

    public enum Weekdays
    { 
        Su,
        Mo,
        Tu,
        We,
        Th,
        Fr,
        Sa
    }

}
