namespace Containers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tömbök létrehozása.
            //A kapacitást nem tudjuk módosítani menet közben
            int[] ints = { 1, 2, 3 };
            int[] ints2 = new int[3];

            ints[0] = 11; //1 lesz lecserélve 11-re

            //Többdimebziós
            bool[,] bools = new bool[2,3]; //2X3 Mátrix

            bools[0, 0] = true;

            //ints[2] = 33; //Látszólag nincs gond, de run timenál OutOfRangeException lesz

            Console.WriteLine();

            //Listák
            //Generikus lista, azaz meg is mondom az elemek típusát
            //Dinamikusan bővíthető
            List<int> list1 = new List<int>();
            list1.Add(11);
            list1.Add(22);
            list1.Add(33);

            //Bejárások

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }

            //Többdimenziós lista
            //Olyan lista kell aminek lista típusú az eleme
            List<List<bool>> boollist = new List<List<bool>>();
            //Belső lista. Ezt nem tudom indexel kezelni
            List<bool> innerboollist = new List<bool>();
            innerboollist.Add(false);
            innerboollist.Add(true);
            innerboollist.Add(false);
            innerboollist.Add(true);
            innerboollist.Add(false);

            List<bool> innerboollist2 = new List<bool>();
            innerboollist2.Add(false);
            innerboollist2.Add(true);
            innerboollist2.Add(false);
            innerboollist2.Add(true);
            innerboollist2.Add(false);
            innerboollist2.Add(false);
            innerboollist2.Add(false);
            innerboollist2.Add(true);
            innerboollist2.Add(false);
            innerboollist2.Add(true);

            boollist.Add(innerboollist);
            boollist.Add(innerboollist2);

            Console.WriteLine();

            //dictionary
            Dictionary<int, bool> dict1 = new Dictionary<int, bool>();
            dict1.Add(1, false);
            dict1.Add(2, true);
            dict1.Add(3, false);
            dict1.Add(4, true);
            dict1.Add(5, false);
            dict1.Add(6, true);

            foreach (KeyValuePair<int, bool> pair in dict1)
            {
                Console.WriteLine($"Key : {pair.Key} Value : {pair.Value}");
            }
        }
    }
}
/*
 Ezek is objektumok, és sok interface-t megvalósítanak.
 */
