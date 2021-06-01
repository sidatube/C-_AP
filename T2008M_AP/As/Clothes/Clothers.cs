using System;

namespace T2008M_AP.As.Clothes
{
    public abstract class Clothers
    {
        private string area;
        private double total;

        protected Clothers()
        {
        }

        protected Clothers(string area, double total)
        {
            this.area = area;
            this.total = total;
        }

        public string Area
        {
            get => area;
            set => area = value;
        }

        public double Total
        {
            get => total;
            set => total = value;
        }



        public void Sale()
        {
           Console.WriteLine("Area: "+ Area +"-- Total: "+ Total);
        }
        public abstract void Materials();
        public abstract void CommonWear();
        public abstract void Showinfor();
        
    }
}