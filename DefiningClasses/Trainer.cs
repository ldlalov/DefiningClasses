using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int BadgesCount { get; set; }
        public List<Pokemon> Pokemons = new List<Pokemon>();
    }
}
