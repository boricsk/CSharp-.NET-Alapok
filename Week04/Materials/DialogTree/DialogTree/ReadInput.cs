namespace DialogTree
{
    public static class ReadInput
    {
        public static string ReadName()
        {
            string? name = null;
            Console.Write("Hi there! ");
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();
            }
            return name;
        }

        public static int GetNumber()
        {
            int result;
            Console.WriteLine("Your choice:");
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("I need a number here!");
            }
            return result;
        }
    }
}
