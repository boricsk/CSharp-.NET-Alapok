namespace DialogTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preparing an advanture for you...");
            Player p = new(ReadInput.ReadName());
            HackersLife hl = new(p);
            hl.Run();
        }
    }
}