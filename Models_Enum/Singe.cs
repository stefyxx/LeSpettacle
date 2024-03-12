using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeSpettacle.Models_Enum
{
    public class Singe
    {
        public int Name { get; set; }
        public List<Tour> Tours = new List<Tour>();

        public Singe(int name, Tour tour)
        {
            this.Name = name;
            AddTours(tour);          
        }
        public Singe(int name, List<Tour> tours)
        {
            this.Name = name;
            this.Tours = tours;    
        }
        public void AddTours(Tour tour)
        {
            this.Tours.Add(tour);
        }
    }
}
