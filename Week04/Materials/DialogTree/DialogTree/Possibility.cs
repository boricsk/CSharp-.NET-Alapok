namespace DialogTree
{
    internal class Possibility
    {
        public int Id { get; }
        public string Title { get; }
        public string Text { get; }
        public List<int> NextPos { get; }
        public Possibility(int id, string title, string text, List<int> nextPos)
        {
            Id = id;
            Title = title;
            Text = text;
            NextPos = nextPos;
        }
    }
}
