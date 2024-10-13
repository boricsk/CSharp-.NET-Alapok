namespace _05_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            i = 42;

            string aaa = "aaa";

            string number = "100";

            int x = int.Parse(number); //Átalakítja int-é

            int char_num = Console.Read();
            Console.WriteLine(char_num);
            Console.ReadLine();

            string inputtext = Console.ReadLine();
            Console.WriteLine(inputtext);
            Console.ReadLine();

            //ConsoleKeyInfo változótípust fog visszaadni
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(key.Key);
            Console.ReadLine();
        }
    }
}
