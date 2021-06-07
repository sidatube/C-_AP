using System;

namespace T2008M_AP.Pratical.GeometryExample
{
    public class GeometryExample
    {
        private double radius;
        private double height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;

        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public double Height
        {
            get => height;
            set => height = value;
        }

        public double BaseArea
        {
            get => baseArea;
            set => baseArea = value;
        }

        public double LateralArea
        {
            get => lateralArea;
            set => lateralArea = value;
        }

        public double TotalArea
        {
            get => totalArea;
            set => totalArea = value;
        }

        public double Volume
        {
            get => volume;
            set => volume = value;
        }

        public GeometryExample()
        {
        }

        public GeometryExample(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void showinput()
        {
            Console.WriteLine("Radius: "+Radius);
            Console.WriteLine("Height: "+Height);
        }
        public void process()
        {   
             BaseArea = Radius * Radius * Math.PI;
             LateralArea = 2 * Math.PI * Radius * Height;
             TotalArea =2 * Math.PI * Radius * (Height+Radius);
             Volume =  Math.PI * Radius * Radius * Height;
        }

        public void result()
        {
           
            Console.WriteLine("Base: "+BaseArea+"| Lateral: "+LateralArea+"| Total: "+TotalArea+"| Volume: "+Volume);
        }
    }
}