namespace DialogTree
{
    internal class Player
    {
        public string Name { get; }
        public int Health { get; set; } = 50;
        public bool Pendrive { get; set; }
        public Player(string name)
        {
            Name = name;
        }
    }
}
