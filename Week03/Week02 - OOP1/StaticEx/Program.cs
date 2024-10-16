namespace StaticEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sima class
            AddNum c1 = new();
            c1.Add(2,3);

            //Static class, nem kell (nem is lehet) példányosítani
            AddNumStat.Add(2, 3);
        }
    }

    interface IAddNumStat { }
    class AddNum
    { 
        //statikus property hozzáadása lehetséges
        public int Add(int a, int b)
            { return a + b; }
    }

    static class AddNumStat
    { 
        public static int Add(int a, int b) { return a + b; }
    }
}

/*
A statikus osztály nem támogatja az öröklést és az interface-t sem.
Helper osztályokhoz (Math) célszerű használni. Projectben lévő globális
változóhoz.
 */
