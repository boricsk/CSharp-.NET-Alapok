namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coords c = new Coords();
            c.X = 1; c.Y = 2;
            Console.WriteLine(c.Pos() ? "p" : "n");
        }

        struct Coords
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Coords()
            {
                X = 0;
                Y = 0;
            }
            public bool Pos() { return X > 0 && Y > 0 ? true : false; }
        }
    }
}
/*
 A hasztálata szinte azonos az osztályok használatával, azonban ez Value Type,
az osztály pedig Ref. type. akkor hatékony válaszás, ha kis strutúrát használunk
amiben nincs sok metódus / property. Az öröklést nem támogatja! (nem lehet benne
abstract, sealed, virtual, protected) Interface-t viszont meg tud valósítani.
*/
