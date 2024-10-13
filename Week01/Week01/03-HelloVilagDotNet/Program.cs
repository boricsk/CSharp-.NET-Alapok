namespace _03_HelloVilagDotNet
{
    //Do not use top level statement esetén ez a kód.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
        }
        //Visszatérési érték (a void azt jelenti nincs)
        static int Main2(string[] args)
        {
            Console.WriteLine("Hello, World!");
            return 0;
        }
    }
}
