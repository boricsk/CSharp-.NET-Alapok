namespace Easter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to easter project");
            Console.WriteLine($"Easter Monday : {calc_easter_monday(2024)}");
            Console.WriteLine($"Pentecost : {calc_pentecost(2024)}");

        }

        static int get_year()
        {
            int year = 0;
            Console.WriteLine("Enter the year");
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("This is not a number!");
            }
            return year;
        }

        static DateTime calc_easter_monday(int year)
        {
            DateTime ret = new DateTime(year, 3, 1);
            int a = year % 19;
            int b = year % 4;
            int c = year % 7;
            int d = ((19 * a) + 24) % 7;
            int e = (2 * b + 4 * c + 6 * d + 5) % 7;
            int h = 0;

            if ((e == 6) && (d == 28) && (a > 10))
            {
                h = 50;
            }
            else
            {
                if (e == 6 && d == 28 && a > 10) { h = 49; } else { h = 22 + d + e; }
            }

            return ret.AddDays(h);
        }

        static DateTime calc_pentecost(int year)
        {
            return calc_easter_monday(year).AddDays(49);
        }

    }
}
/*
Húsvét vasárnapja minden évben a tavaszi napéjegyenlőséget követő holdtölte 
utáni első vasárnap, így dátuma március 22. és április 25. között változhat. 
Ennek meghatározására alkalmas a következő egyszerűsített algoritmus. 
Jelölje T az évszámot (1901<=T<=2099). Kiszámítjuk a következő osztási maradékokat:

    A = T / 19 maradéka
    B = T / 4 maradéka
    C = T / 7 maradéka
    D = (19A+24) / 30 maradéka
    E = (2B+4C+6D+5) / 7 maradéka.

Ezekből a húsvét-vasárnap dátuma H=22+D+E, ami márciusi dátum, ha H<=31, 
különben áprilisban H-31. 

Azonban létezik két kivétel: 
ha E=6 és D=29, akkor H=50, illetve 
ha E=6 és D=28 és A>10, akkor H=49. 

Pünkösd minden évben húsvét után hét héttel következik.
 */