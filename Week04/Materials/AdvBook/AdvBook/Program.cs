namespace AdvBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new(ReadInput.GetName());
            SHackersLife hl = new(p, "The Hackers Life");
            hl.Run();

        }
    }
}
