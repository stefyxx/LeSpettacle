using LeSpettacle.Enum;
using LeSpettacle.Models_Enum;
using LeSpettacle.Utilities;
using Microsoft.VisualBasic;

namespace LeSpettacle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Halloo!");
            #region Spectateur
            Console.WriteLine("Créez votre spectateur");
            string nomSpectateur = CommonFunctions.AskMyName();
            Spectateur spectateur = new Spectateur(nomSpectateur);
            #endregion

            string singename = "premier";
            #region Premier singe  
            Singe premier = CommonFunctions.AddOneSinge(singename);
            #endregion

            #region Premier dresseur
            Console.WriteLine("Créez votre premier dresseur");
            string nomDresseur = CommonFunctions.AskMyName();
            Dresseur premierD = new Dresseur(nomDresseur,premier);
            #endregion

            singename = "deuxième";
            #region Deuxième Singe
            Singe deuxieme = CommonFunctions.AddOneSinge(singename);
            #endregion

            #region Deuxième dresseur
            Console.WriteLine("Créez votre deuxième dresseur");
            string nomDresseur2 = CommonFunctions.AskMyName();
            Dresseur deuxiemeD = new Dresseur(nomDresseur2, deuxieme);
            #endregion

            Console.WriteLine("Le spectacle commence!");

            premierD.JouerSinge(spectateur);
            deuxiemeD.JouerSinge(spectateur);


        }

        //static string AskMyName()
        //{
        //    string nom;
        //    do
        //    {
        //        Console.WriteLine("Quel est son prénom? 'Rien' ne sera pas accepté");
        //        nom = Console.ReadLine();

        //    } while (nom == "");
        //    return nom;
        //}

        //static Singe AddOneSinge(string nbSinge)
        //{
        //    bool conversion;
        //    int quantiteTours = 0;
        //    do
        //    {
        //        Console.WriteLine($"et maintenant, combien de tours le {nbSinge} singe aura-t-il?, Inserez un numero de 1 a 10");
        //        conversion = int.TryParse(Console.ReadLine(), out quantiteTours);

        //    } while (!conversion || quantiteTours < 1 || quantiteTours > 11);

        //    Console.WriteLine("et maintenant, quels tours le premier singe aura-t-il ?");
        //    List<Tour> tours = new List<Tour>();
        //    for (int i = 0; i < quantiteTours; i++)
        //    {
        //        int typeTour;
        //        conversion = false;
        //        do
        //        {
        //            Console.WriteLine("Choisir entre");
        //            Console.WriteLine("1 : tour acrobatique");
        //            Console.WriteLine("2 : tour musical");
        //            conversion = int.TryParse(Console.ReadLine(), out typeTour);
        //        } while (!conversion || typeTour > 2 || typeTour < 0);
        //        string nameTour;
        //        do
        //        {
        //            Console.WriteLine("Tour avec name, 'rien' ne sera pas accepté ");
        //            nameTour = Console.ReadLine();

        //        } while (nameTour == "");

        //        Tour t = new Tour(nameTour, (TypeTour)typeTour);
        //        tours.Add(t);
        //    }
        //    Singe singe;
        //    if (nbSinge == "premier") { singe = new Singe(1, tours); }
        //    else { singe = new Singe(2, tours); }
        //    return singe;
        //}
    }
}
