using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBook
{
    public class Possibility
    {
        public string Id { get; }
        public string Title { get; }
        public string Text { get; }
        public List<string> NextPos { get; }
        public Possibility(string id, string title, string text, List<string> nextPos)
        {
            Id = id;
            Title = title;
            Text = text;
            NextPos = nextPos;
        }
    }
}
