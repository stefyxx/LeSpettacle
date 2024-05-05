using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeSpettacle.Models_Enum
{
    public class Dresseur
    {
        private string Name { get; set; }
        private Singe Singe { get; set; }

        public Dresseur(string name, Singe singe)
        {
            this.Name = name;
            this.Singe = singe;
        }

        public void JouerSinge(Spectateur s)
        {
            foreach (Tour t in Singe.Tours)
            {
                s.Reagir(t, Singe);
            }
        }

    }
}
