namespace DialogTree
{
    internal class HackersLife : Story
    {
        private List<Possibility> Possibilities { get; }
        public HackersLife(Player player) : base(player)
        {
            Possibilities = new();
            Possibilities.Add(new(1, "The setup", $"Their mission was to infiltrate a highly secure government database rumored to hold classified information about top - secret experiments.\nWith fingers dancing across the keyboard, {player.Name} initiated a sophisticated chain of proxy servers and encryption protocols to conceal their identity. ", new List<int> { 2, 3 }));
            Possibilities.Add(new(2, "Meet Cipher", "As Cipher delved deeper into the digital labyrinth, they encountered formidable firewalls and a complex web of security algorithms.\nEach obstacle they overcame brought them closer to the coveted information. ", new List<int> { 3, 4 }));
            Possibilities.Add(new(3, "Go on alone", $"Hours turned into days as {player.Name} persisted, bypassing biometric locks and cracking intricate passwords.\nThe adrenaline surged through their veins with each successful breach, but the risk of discovery grew ever more palpable.", new List<int> { 2, 3 }));
            Possibilities.Add(new(4, "Break-through", "Finally, they reached the heart of the database, discovering chilling revelations about unethical experiments conducted on unsuspecting citizens. \n", new List<int> { 5, 6 }));
            Possibilities.Add(new(5, "Do what you want", $"{player.Name}  couldn't just leave this buried in the digital abyss, so they encrypted the data and sent it to the press.", new List<int> { 7 }));
            Possibilities.Add(new(6, "Do what Cipher wants", "As dawn broke, Cipher retreated into the digital shadows, leaving behind a trail of questions and a world forever changed by their daring adventure into the unknown.", new List<int> { 7 }));
       }

        public override void Run()
        {
            Possibility currentChoice = Possibilities[0];

            while (true)
            {
               // Console.Clear();
                Console.WriteLine($"{ThePlayer.Name} | HP: {ThePlayer.Health}");
                Console.WriteLine(currentChoice.Title);
                Console.WriteLine();
                Console.WriteLine(currentChoice.Text);

                if (currentChoice.NextPos.Count > 0 && ThePlayer.Health > 0)
                {
                    Console.WriteLine("\nChoose!");
                    foreach (int id in currentChoice.NextPos)
                    {
                        Possibility? possibility = GetChoice(id);
                        Console.WriteLine($"{id}: {possibility?.Title ?? "-Unknown way-"}");
                    }

                    Possibility? nextChoice;

                    int chnum;
                    do
                    {
                        chnum = ReadInput.GetNumber();
                    } while (((nextChoice = GetChoice(chnum)) == null) || !currentChoice.NextPos.Contains(chnum));

                    currentChoice = nextChoice;

                    switch (currentChoice.Id)
                    {
                        case 3:
                            Console.WriteLine("You are getting tired. (Health down with 20 points)");
                            ThePlayer.Health -= 20;
                            break;
                        case 7:
                            ThePlayer.Pendrive = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Your story ends here.");
                    break;
                }
            }
        }

        private Possibility? GetChoice(int id)
        {
            foreach (Possibility possibility in Possibilities)
            {
                if (possibility.Id == id)
                {
                    return possibility;
                }
            }
            return null;
        }
    }
}
