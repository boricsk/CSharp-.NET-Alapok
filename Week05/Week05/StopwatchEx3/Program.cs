/*
 Függvény mint obj.
Az absztrakció megvalósításához 3 osztályt használtunk, 2-ben volt kód írva.
Elegendő lenne paramérerül átadni a két függvényt egy időmérőnek.
Erre van lehetőség.

Függvény kompatibilitás
Két fgv kompatibilis ha a paraméterlistájuk (paraméterek száma, sorrendje, típusa) 
és visszatéeési értékük megegyezik. A paraméterek neve lehet eltérő.
A void fgv-ket Action-nek, ami visszatér Func-nak nevezzük.

Delegáltak (Delegate)
Olyan fgv-k amiket helyben írunk meg és pélgánypsítunk. a háttérben a delegált
saját, névtelen oaztályt készít, aminek paraméterül átadja a környezetből szükséges
változókat amiket kontextusnak hívhatunk.
A System.Action és a System.Func beépített delegált típusok
Lehet saját delegált típust is készíteni az fgv szignatúra megadásával, de mivel az 
Action és a Func univerzálisak ennek nem sok értelme van.

Az Action típusparaméterül várja a fgv paramétereinek típusát. Az Action<int, int, string>
2 intet és 1 stringet vár és nem tér vissza semmivel.
A Func esetében is ez a helyzet, de itt az utolsó a visszatérés típusa.
Func<int> nem vár paramétert, int-el tér vissza
Func<int, int, int> paraméter 2 int és int-el tér vissza.

Függvényparaméter : Függvény
Tudunk olyan fgv-t készíteni ami fgv-t vár paraméterül.

static void Meres(string nev, Action muvelet)
{
    var stopwatch = Stopwatch.StartNew();
    muvelet();
    Console.WriteLine($"{Nev} : {stopwatch.ElapsedMilliseconds} [ms]");
}

Az új implementáció:

    var random = new Random();

    Meres("Lista", () =>
    {
        var list = new List<int>();
        foreach (var szam in Enumerable.Range(1, 100000))
        {
            var r = random.Next(0, szam);
            if (!list.Contains(r)) { list.Add(r); }
        }
    });


    Meres("Halmaz", () => 
        var set = new HashSet<int>();
        foreach (var szam in Enumerable.Range(1, 100000))
        {
            var r = random.Next(0, szam);
            if (!set.Contains(r)) { set.Add(r); }
        }
    });

A random egy külső változó, de használjuk belül. Ezt Closer-nek hívjuk.
Ez a változó a névtelen osztály tulajdonsága lesz.

() => {} Nem csinál semmit
() => Console.WriteLine("..") Egysoros kifejezés esetén nem kell {}

Több sor esetén kell a {}
() => 
{
    Console.WriteLine("..")
    Console.WriteLine("..")
}

A paraméterül kapott x-het 1 et hozzáad és azt adja vissza
(int x) => x+1
(int x) => 
{
    return x+1;
}

Ha több paraméterünk van akkor vesszővel kell felsorolni
(x,y) => x+y+1

Ha csak 1 paraméter van a () el lehet hagyni
x => x+1
alma => alma + 1




 */
using System.Diagnostics;

namespace StopwatchEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            Meres1("Lista", () =>
            {
                var list = new List<int>();
                foreach (var szam in Enumerable.Range(1, 100000))
                {
                    var r = random.Next(0, szam);
                    if (!list.Contains(r)) { list.Add(r); }
                }
            });

            Meresek.Meres("Halmaz", () =>
            {
                var set = new HashSet<int>();
                foreach (var szam in Enumerable.Range(1, 100000))
                {
                    var r = random.Next(0, szam);
                    if (!set.Contains(r)) { set.Add(r); }
                }
            });

        }

        static void Meres1(string nev, Action muvelet)
        {
            var stopwatch = Stopwatch.StartNew();
            muvelet();
            Console.WriteLine($"{nev} : {stopwatch.ElapsedMilliseconds} [ms]");
        }
    }
}
