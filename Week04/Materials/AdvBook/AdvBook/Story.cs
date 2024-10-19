using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBook
{
    internal abstract class Story
    {
        public Player ThePlayer { get; }
        public string Title { get; }
        public abstract void Run();
        protected Story(Player player, string title)
        {
            ThePlayer = player;
            Title = title;
        }
    }
}
