using System;

namespace T2008M_AP.As.Clothes
{
    public class Sports : Clothers
    {
        public Sports()
        {
        }

        public Sports(string area, double total) : base(area, total)
        {
        }

        public override void Materials()
        {
            Console.WriteLine(
                "Materials: \n 1.Viscose \n 2.Cotton \n 3.Flax \n 4.Woo \n 5.l Hemp \n 6.Ramie \n 7.Silk \n 8.Lyocell and so on");
        }

        public override void CommonWear()
        {
            Console.WriteLine("CommonWear: Skirts, trousers, jackets, blouses, tops, dresses, and shirts. ");
        }
        public override void Showinfor()
        {
            Console.WriteLine("Sports Garments's");
            Materials();
            CommonWear();
        }
    }
}