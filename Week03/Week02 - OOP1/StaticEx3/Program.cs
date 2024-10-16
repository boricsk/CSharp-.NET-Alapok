namespace StaticEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Have a nice day";
            Console.WriteLine(text.Wavy());

        }
    }

    static class StringExt
    {
        public static string Wavy(this string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    res += char.ToUpper(str[i]);
                }
                else 
                {
                    res += char.ToLower(str[i]);
                }
            }
            return res;
        }
    }

    public sealed class Singleton
    {
        private Singleton()
        {

        }
        private static Singleton? instance;
        public static Singleton? Instance
        {
            get
            {
                if (instance == null) { instance = new(); }
                return instance;
            }
        }
    }
}
/*
Spec. eset
Sealed-el ki lehet zárni az osztályt az öröklési láncból.
Ezt lehet meghekkelni a static segítségével, Extension Method
hívják ezt a megoldást.

Kell egy ststic osztály StringExt, és egy static metódus.
Mivel stringet akarjuk kiterjeszteni kell a this string.
A this után kell megmondani, hogy milyen típst akarok kiterjeszteni.
Fontos, hogy static legyen az osztály is és a metódus is.

Az eredmény, hogy a lezárt string osztályra sikeresen rátettem
a Wavy()-t.

*/