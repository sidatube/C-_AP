using System;

namespace T2008M_AP.As.Clothes
{
    public class Trend : Clothers
    {
        public Trend()
        {
        }

        public Trend(string area, double total) : base(area, total)
        {
        }

        public override void Materials()
        {
            Console.WriteLine("Materials: \n 1.Cotton Polyester \n 2.Rayon \n 3.Linen \n 4.Satin \n 5.Georgette \n 6.Moss Crepe \n 7.Net \n 8.Lace \n 9.Jacquard Velvet");
        }

        public override void CommonWear()
        {
            Console.WriteLine("CommonWear: Skirts, trousers, jackets, blouses, tops, dresses, and shirts. ");

        }
        public override void Showinfor()
        {
            Console.WriteLine("Trend Setting Garments's");
            Materials();
            CommonWear();
        }
    }
} 

       