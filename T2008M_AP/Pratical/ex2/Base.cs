using System;

namespace T2008M_AP.Pratical.ex2
{
    public class Base
    {
        private double weight;
        private string name;

     

        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: "+Name+", Weight: "+Weight);
        }

        public virtual void Setme(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}