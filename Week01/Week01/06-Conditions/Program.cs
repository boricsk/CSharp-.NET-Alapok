using System.Security.Cryptography;

namespace _06_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 11;

            if (i == 10)
            {
                Console.WriteLine("ten");
            }
            else
            {
                Console.WriteLine("Not ten");
            }

            int x = (i == 10) ? 1 : 2;
            Console.WriteLine(x);

            bool b = false;
            int a1 = 10; int a2 = 20;

            x = (b) ? a1 : a2;
            Console.WriteLine(x);

            switch (x)
            {
                case 1:
                    Console.WriteLine("One");
                    break; //kell, ha nincs akkor tovább megy.
                case 2:
                case 3:
                    Console.WriteLine("Two or Three");
                    break;
                default:
                    Console.WriteLine("Not 1, 2 or 3");
                    break;

            }

        }

    }
}
