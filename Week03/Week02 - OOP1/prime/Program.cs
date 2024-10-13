namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Az osztály példányának létrehozása
            PrimeCounter pc = new PrimeCounter(2,10);

            //int ll = 2; int hl = 10;
            //int counter = 0;

            //for (int i = ll; i <= hl; i++)
            //{
            //    if (pc.is_prime(i)) { counter++; }
            //}

            Console.WriteLine(pc.get_count());
        }

        //Szükség van egy metódusra, ami el tudja dönteni, hogy egy szám prím-e

        //static bool is_prime(int p)
        //{
        //    for (int i = 2; i <= Math.Sqrt(p); i++)
        //    {
        //        if (p % i == 0) { return false; }
        //    }
        //    return true;
        //}

    }

    //Hogyan lesz ez OOP?
    //Osztály definiálás
    public class PrimeCounter
    {
        //Limitek áthelyezése az osztályba
        int ll = 2; int hl = 10;
        int counter = 0;

        //Construktor, ezzel adunk értéket a limitnek,ez azt jelenti,
        //hogy ezekkel a paraméterekkel kell példányosítani.
        //A neve = osztály neve
        public PrimeCounter(int a, int b)
        {
            ll = a;
            hl = b;
        }

        //Helyezzük ide az elkészült függvényt
        public bool is_prime(int p)
        {
            for (int i = 2; i <= Math.Sqrt(p); i++)
            {
                if (p % i == 0) { return false; }
            }
            return true;
        }

        //A talált prímek számát adja vissza
        public int get_count()
        {
            for (int i = ll; i <= hl; i++)
            {
                if (is_prime(i)) { counter++; }
            }
            return counter;
        }
    }
}
/*
PrimeCounter pc = new PrimeCounter(2,10);
Igazából egy típus def. ezt a class kulcsszóval hozzuk létre. A pc a példány neve.
Ez egy változó és tartaalmazza az osztály metódusait és tulajdonságait is ezen keresztül lehet elérni.
Az osztályban definiált dolgoat ezen keresztül tudom elérni, ezek lehetnek:

-Field
-Property
-Method
-Constructor ...

OOP Paradigmák, Alapelvek

Encapsulation
Tartsuk egyben az összefüggő információkat.

Inheritance
Az Ösétől minden tudást örökölni fog öröklés esetén.

Polimorphism
Ugyanazzam a metódus névvel saját működést lehet definiálni.

Abstraction
A komplex belső logika elrejtése
(A prime counter létrehozásával egy új absztrakciós szint jött létre)


*/