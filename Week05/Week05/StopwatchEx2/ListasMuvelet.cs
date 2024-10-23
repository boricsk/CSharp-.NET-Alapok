using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchEx2
{
    public class ListasMuvelet : Muvelet
    {
        public ListasMuvelet() : base("Lista")
        {
            
        }

        protected override void MerendoMuveletVegrehajtása()
        {
            var random = new Random();
            var list = new List<int>();
            foreach (var szam in Enumerable.Range(1, 100000))
            {
                var r = random.Next(0, szam);
                if (!list.Contains(r)) { list.Add(r); }
            }
        }
    }
}
