using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeSpettacle.Enum;

namespace LeSpettacle.Models_Enum
{
    public class Tour
    {
        public string Name { get; set; }

        public TypeTour Type { get; set; }
        public Tour(string name, TypeTour type)
        {
            Name = name;
            Type = type;
        }

    }
}
