namespace pract_fibonacci
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = 39; // Fibonacci szám kiszámítása a 10. pozícióra
            
            for (int i = 0; i < n; i++)
            {
                int result = FibonacciGyors(i);
                Console.WriteLine($"{i}         {result}");
            }
        }

        static int FibonacciGyors(int n)
        {
            int?[] fibonacciSzam = new int?[n + 1]; // Nullable int array a memoizációhoz

            int FibRekurziv(int x)
            {
                if (fibonacciSzam[x].HasValue) // Ellenőrzi, hogy már kiszámították-e
                {
                    return fibonacciSzam[x].Value;
                }
                else
                {
                    int eredmeny;
                    if (x <= 1)
                    {
                        eredmeny = x; // Az alap eset
                    }
                    else
                    {
                        eredmeny = FibRekurziv(x - 1) + FibRekurziv(x - 2); // Rekurzív hívás
                    }
                    fibonacciSzam[x] = eredmeny; // Eredmény tárolása
                    return eredmeny;
                }
            }

            return FibRekurziv(n); // Kiinduló hívás
        }
    }

}
