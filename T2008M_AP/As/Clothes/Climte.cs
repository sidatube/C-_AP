using System;

namespace T2008M_AP.As.Clothes
{
    public class Climte : Clothers
    {
        public Climte()
        {
        }

        public Climte(string area, double total) : base(area, total)
        {
        }

        public override void Materials()
        {
            Console.WriteLine("Materials: \n These garments mostly use knit fabrics using different thickness of wool depending upon the severity of the winter winds. As the climatic conditions are extreme, they deal with the development of: \n Heated clothing \n Wind Resistant Upper clothing ");
        }

        public override void CommonWear()
        {
            Console.WriteLine("CommonWear: \n" +
                              "-Heated clothing\n" +
                              "-Wind Resistant Upper clothing ");
        }

        public override void Showinfor()
        {
            Console.WriteLine("Climate Control Garments's");
            Materials();
            CommonWear();
        }
    }
} 
