using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBook
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
