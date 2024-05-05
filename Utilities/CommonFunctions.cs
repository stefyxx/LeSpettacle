using LeSpettacle.Enum;
using LeSpettacle.Models_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeSpettacle.Utilities
{
    public static class CommonFunctions
    {
        public static string AskMyName()
        {
            string nom;
            do
            {
                Console.WriteLine("Quel est son prénom? 'Rien' ne sera pas accepté");
                nom = Console.ReadLine().Trim();

            } while (string.IsNullOrEmpty(nom));
            return nom;
        }

        public static Singe AddOneSinge(string nbSinge)
        {
            bool conversion;
            int quantiteTours = 0;
            do
            {
                Console.WriteLine($"et maintenant, combien de tours le {nbSinge} singe aura-t-il?, Inserez un numero de 1 a 10");
                conversion = int.TryParse(Console.ReadLine(), out quantiteTours);

            } while (!conversion || quantiteTours < 1 || quantiteTours > 11);

            Console.WriteLine("et maintenant, quels tours le premier singe aura-t-il ?");
            List<Tour> tours = new List<Tour>();
            for (int i = 0; i < quantiteTours; i++)
            {
                int typeTour;
                conversion = false;
                do
                {
                    Console.WriteLine("Choisir entre");
                    Console.WriteLine("1 : tour acrobatique");
                    Console.WriteLine("2 : tour musical");
                    conversion = int.TryParse(Console.ReadLine(), out typeTour);
                } while (!conversion || typeTour > 2 || typeTour < 0);
                string nameTour;
                do
                {
                    Console.WriteLine("Tour avec name, 'rien' ne sera pas accepté ");
                    nameTour = Console.ReadLine();

                } while (nameTour == "");

                Tour t = new Tour(nameTour, (TypeTour)typeTour);
                tours.Add(t);
            }
            Singe singe;
            if (nbSinge == "premier") { singe = new Singe(1, tours); }
            else { singe = new Singe(2, tours); }
            return singe;
        }
    }
}

