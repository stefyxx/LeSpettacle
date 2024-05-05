using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeSpettacle.Enum;

namespace LeSpettacle.Models_Enum
{
    public class Spectateur
    {
        public string Name { get; set; }
        public Spectateur(string name)
        {
            this.Name = name;
        }

        public void Reagir(Tour tour, Singe singe)
        {
            if(tour.Type == TypeTour.Acrobatie) { Applaudir(tour.Name, singe.Name); }
            else { Siffler(tour.Name, singe.Name); }
        }
        public void Applaudir(string tour, int singeName)
        {
            Console.WriteLine($"Le spectateur {this.Name} applaudit pendant le tour d'acrobatie '{tour}' du singe {singeName}");
        }

        public void Siffler(string tour, int singeName)
        {
            Console.WriteLine($"Le spectateur {this.Name} siffle pendant le tour musical '{tour}'  du singe {singeName}");
        }
    }
}
