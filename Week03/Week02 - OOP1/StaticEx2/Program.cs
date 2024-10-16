namespace StaticEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Látszólag 3 van, de ugyanazok lesznek
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Singleton s3 = Singleton.Instance;
        }
    }

    public sealed class Singleton
    {
        //Ha példányosítani akarom gond lesz mert a láthatóság
        //miatt nem elérhető a konstruktor
        private Singleton()
        {
            
        }

        //propfull snippettel a property mellé egy field is készül.
        //a static azt jelenti, hogy egy osztályszintű változó lesz.
        //nem a példányhoz tartozó változó lesz, hanem a típushot tartozó
        private static Singleton? instance;

        public static Singleton? Instance
        {
            get 
            {
                //ha nincs példány belőle akkor meghívom a konstruktort,
                //ha van egyanazt a példányt adom vissza
                if (instance == null) { instance = new(); }
                return instance; 
            }
            //ne legyen változtatható.
            //set { instance = value; }
        }

    }
}
/*
Design patternek ált. összetettebb feladatok megoldásának best paractise-e.
Tegyük fel, hogy szeretném megoldani, hogy valamilyen obj-ből csak 1 darab 
lehessen. Ez a Singletone pattern.

 */