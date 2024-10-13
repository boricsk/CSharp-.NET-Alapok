namespace _04_OwnType
{
    internal class Dog
    {
        // Van egy olyan képessége hogy tud játszani
        public void PlayGame()
        {
            Console.WriteLine("I'm running");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog típusú változó Killer névvel (deklarációs rész)
            Dog Killer;
            //Példány létrehozása (példányosítás)
            Killer = new Dog();

            Killer.PlayGame();
            //Console.WriteLine("Hello, World!");
        }
    }
}
