namespace DialogTree
{
    internal abstract class Story
    {
        public Player ThePlayer { get; }
        public abstract void Run();
        public Story(Player player)
        {
            ThePlayer = player;
        }        
    }
}
