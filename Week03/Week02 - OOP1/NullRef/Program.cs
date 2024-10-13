namespace NullRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem p = new Problem();
            p.PrintOut();
            Console.WriteLine("----------------");
            //PrintOut2

            int a = 1;
            int[] b = new int[1] { 2 };
            //Valójában ez csak módosítja az értéket, azt várjuk, hogy 
            //10 és 20 lesz kiirva de valójában 1, 20 lesz az eredmény.
            //Ha a value typeot paraméterként átadom akkor értéket adok át amivel tudok
            //műveleteket végezni. A reference type esetén egy pointer megy át, és a hivatkozott 
            //memória területen fogok változtatni, ez a terület az eredeti helyről is látni a változást.
            p.PrintOut2(a, b);
            Console.WriteLine($"a : {a}, b[0] : {b[0]}");

            //a ref kulcsszó hatására a .NET referenciaként kezeli.
            p.PrintOut3(ref a, b);
            Console.WriteLine($"a : {a}, b[0] : {b[0]}");

            //az out esetén a metódusban kötelező neki értéket adni, míg ez a ref-el nem kötelező
            //van még in is, amely azt iíra elő, hogy kötelező legyen a bemenő érték
            p.PrintOut4(out a, b);
            Console.WriteLine($"a : {a}, b[0] : {b[0]}");


            //Stringek
            string s = "123";
            int x;

            //Ha sikeres az átalakítás akkor visszatér az x, de mivel value type az int
            //ezért ref vagy out használata kell a tryParse-ban.
            int.TryParse(s, out x);

            string s2; //Nics benne semmi
            string s3 = ""; //Üres string
            string? s4 = null; //Nullable type-ok létrehozása, ezek felvehetik a null értéket.

            if (string.IsNullOrEmpty(s4))
            {

            }

            Console.WriteLine($"Nullable s4 : {s4}");

            int? i4 = null;
            Console.WriteLine($"Nullable i4 : {i4}");
            Console.WriteLine("___________________________");
            
            //Ha nincs inicializálva a property akkor iy lehet nullable-vé tenni
            //így nem kapok kivételt.
            Console.WriteLine($"Counter : {p.Counter?.Count()}");
        }
    }

    class Problem
    {
        //Value type
        int x;

        //Reference type
        int[] xs;

        //Property tömb
        public int[] Counter { get; set; }

        public Problem()
        {
            //Az x sima value type, nem kell new-al példányosítani
            x = 0;

            //A ref. typeok esetében kell a new -al való példányt létrehozni ha használni akarom
            xs = new int[2];
            //Null Reference exception lesz, ha nincs ott a new.
            //Itt nem az értékadás lesz a baj, hanem az ha nincs inicializálva a típus.
            xs[0] = 0;
            xs[1] = 1;

        }

        public void PrintOut()
        {
            Console.WriteLine(x);
            Console.WriteLine($"{xs[0]} , {xs[1]}");
        }

        public void PrintOut2(int y, int[] ys)
        {
            Console.WriteLine("PrintOut2 indul");
            Console.WriteLine($"y értéke a híváskor : {y}");
            y = 10;
            ys[0] = 20;
            Console.WriteLine($"y értéke a változtatás után : {y}");
            Console.WriteLine("PrintOut2 vége");

        }

        public void PrintOut3(ref int y, int[] ys)
        {
            Console.WriteLine("PrintOut3 indul");
            Console.WriteLine($"y értéke a híváskor : {y}");
            y = 10;
            ys[0] = 20;
            Console.WriteLine($"y értéke a változtatás után : {y}");
            Console.WriteLine("PrintOut3 vége");

        }

        public void PrintOut4(out int y, int[] ys)
        {
            Console.WriteLine("PrintOut4 indul");
            Console.WriteLine($"y értéke a híváskor : ");
            y = 10; //out esetében kötelező lesz az értékadás.
            ys[0] = 20;
            Console.WriteLine($"y értéke a változtatás után : {y}");
            Console.WriteLine("PrintOut4 vége");

        }
    }
}
