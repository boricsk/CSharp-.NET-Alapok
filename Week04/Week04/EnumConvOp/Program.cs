namespace EnumConvOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enum elemeinek a listázása
            foreach (ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = item;
                Console.WriteLine("Hello, World!");
            }
            //Ez uganaz mint a foreach
            for (int i = 0; i < 14; i++)
            {
                //A ConsolColorban ConsoleColor típus van ezért kell kasztolni az i-t.
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine("Hello, World!");
            }

            string s = "111";
            int x = int.Parse(s);
            //int x = (int)s; -> Nem lesz jó
            //Direkt módon csak olyan objektumokat lehet kasztolni amik egymással 
            //leszármazási kapcsolatban állnak.



            Car c = new Car();
            c.Id = 111;
            Fiat f = new Fiat();
            f.Type = "Tipo";

            Car c2 = new Car();
            //itt automatikusan történik a kasztolás, nem kel explicit megadni (de meg lehet)
            c2 = f;

            //Ha f Car akkor c2-objektumba bele lehet tenni az f-et 
            if (f is Car) { c2 = f as Car; }

            //Valamilyen pervez okból számmá kell alakítani az osztályt
            //Kell hozzá overload, mert meg kell adni hogy kaszoláskor mi legyen.
            int t = (int)c2;

            //Miles érték növelése
            //Az auto osztályhoz hozzáadok egy számot
            //Azért működik mert van operator overload az osztályban
            //amiben definiálva van mit kell ilyenkor csinálni.
            int b = c2 + 33;

            Console.WriteLine($"Miles {b}");

        }
    }

    public enum Weekdays
    { 
        //Elemeket lehet benne felsorolni és értéket rendelni hozzájuk
        //
        Su = 7,
        Mo = 1,
        Tu = 2,
        We = 3,
        Th = 4,
        Fr = 5,
        Sa = 6,
    }
    class Car
    {
        //int t = int(c2) miatt
        //definiáltam, ha egy autó valaki számmá akar alakítani akkor mi legyen.
        public static explicit operator int(Car mc) { return mc.Id; }

        //A + operator overloadja, azaz definiáljuk, hogy mi legyen ha az osztályon + operátort használunk.
        public static int operator +(Car mc, int add) { mc.Miles += add; return mc.Miles; }
        public int Id { get; set; }
        public int Miles { get; set; }

        public Car()
        {
            Miles = 1000;
        }
    }

    class Fiat: Car
    {
        public string Type { get; set; }
    }

}
