namespace T2008M_AP.As.Zoo
{
    public class Product
    {
        public static void Main(string[] args)
        {
            Elaphant e1 = new Elaphant("African", "4 m", "7000 Kg");
            Elaphant e2 = new Elaphant("Asian", "3.4 m", "5400 Kg");
            e1.ShowInfo();
            e2.ShowInfo();
        }
    }
}