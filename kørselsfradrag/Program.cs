using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kørselsfradrag;



namespace kørselsfradrag // Note: actual namespace depends on the project name.
{
    public class KilometerBeregner
    {
        private const double PrisOver24Km = 2.16;
        private const int GrænseKilometer = 24;

        private double antalKilometer;


        public double AntalKilometer
        {
            get { return antalKilometer; }
            set { antalKilometer = value; }
        }

        public double BeregnPris()
        {
            if (AntalKilometer > 120)
            {

                double over120 = AntalKilometer * 1.08;


                double peng = ((120 - 24) * 2.19 + (AntalKilometer - 120) * 1.1) * 0.26;
                double tillæg = (AntalKilometer - GrænseKilometer) * PrisOver24Km + over120;



                return peng;
            }
            else if (AntalKilometer > GrænseKilometer)
            {
                double tillæg = (AntalKilometer - GrænseKilometer) * PrisOver24Km * 0.26;
                return tillæg;
            }
            else
            {
                return 0;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Beregner nyBer = new Beregner();
            nyBer.Start();
        }

    }
}