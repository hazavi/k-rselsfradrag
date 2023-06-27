using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kørselsfradrag;

namespace kørselsfradrag
{
    public class Beregner
    {
        public void Start()
        {
            Console.Clear();
            Console.Write("Indtast antal kilometer: ");
            string input = Console.ReadLine();
            int bropenge = Bro();

            double antalKilometer;
            if (double.TryParse(input, out antalKilometer))
            {
                KilometerBeregner kilometerBeregner = new KilometerBeregner();
                kilometerBeregner.AntalKilometer = antalKilometer;
                double fradrag = kilometerBeregner.BeregnPris();
                fradrag = Math.Round(fradrag + bropenge, 2);

                Console.WriteLine($"Fradrag for {kilometerBeregner.AntalKilometer} kilometer er: {fradrag.ToString("N2")} kr.");
            }
            else
            {
                Console.WriteLine("Ugyldig indtastning. Indtast venligst et tal.");
            }



            Console.WriteLine("\nVil du lave en ny beregning? (ja/nej)");
            string svar = Console.ReadLine();

            if (svar.ToLower() == "ja" || svar.ToLower() == "j")
            {
                Start();

            }


            Console.WriteLine("\nFor at afslutte programmet, tryk på en tast");
            Console.ReadKey();
        }
        private int Bro()
        {
            Console.WriteLine("Hvad for en bro har du taget (1/2/3)");
            Console.WriteLine("(1) Ingen bro \n(2) Storebæltsbroen \n(3) Øresundsbroen");

            int valg = int.Parse(Console.ReadLine());
            if (valg == 0 || valg > 3)
            {
                Console.WriteLine("Fejl! Prøv igen");
                Console.Clear();
                Bro();
            }
            if (valg == 1) return 0;
            else if (valg == 2) return 220;
            else if (valg == 3) return 100;
            else return 0;
        }
    }
}
