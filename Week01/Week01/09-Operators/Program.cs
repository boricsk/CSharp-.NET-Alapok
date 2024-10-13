namespace _09_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(++x); //először fut a x növelése majd a CW preincrement
            Console.WriteLine(x++); //elősször kiirta majd növekedett postincrement
            Console.WriteLine(x);

            bool a, b;
            a = true;
            b = false;

            if (a && b)
            {
                Console.WriteLine("TRUE");
            }

            int j = 10;
            int k = 5;
            Console.WriteLine(j/k);
            Console.WriteLine(k/j); //mivel int típus 0 lesz, mert itt nem tud 0.5 tárolni
            Console.WriteLine(j%k);
            Console.WriteLine(k%j);
            Console.WriteLine("------------------------------------");

            //Ha double esetén 0-val osztassz nem lesz exeption.
            double j1 = 10;
            double k1 = 5;
            Console.WriteLine(j1 / k1);
            Console.WriteLine(k1 / j1); 
            Console.WriteLine(j1 % k1);
            Console.WriteLine(k1 % j1);
        }
    }
}
