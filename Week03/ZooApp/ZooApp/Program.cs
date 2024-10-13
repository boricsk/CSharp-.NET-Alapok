namespace ZooApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZooApp");
            Zoo z = new("MyZoo");
            //Mivel a SellTicket egy osztályt vát paraméterül
            //A létrehozott ticket példányt is át lehet adni
            //Ticket t = new(2000, "Peti");

            Cat c = new("Tom");
            Horse h = new("Kate");
            z.AddAni(c);
            z.AddAni(h);

            z.SellTicket(new Ticket(2000, "Peti"));
            z.PrintOutAni();
        }
    }
}
