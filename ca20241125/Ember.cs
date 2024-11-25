using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca20241125
{
    internal class Ember
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name} \n {ID}";
        }

        public Ember (string nev)
        {
            ID = Guid.NewGuid();
            Name = nev;
        }
    }
}
