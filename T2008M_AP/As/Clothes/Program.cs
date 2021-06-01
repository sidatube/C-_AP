namespace T2008M_AP.As.Clothes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Clothers p1 = new Climte("HN", 10000);
            Clothers p2 = new Climte("DN", 20000);
            Clothers p3 = new Climte("HCM", 50000);
            Clothers p4 = new Climte("QN", 36000);
            Clothers s1 = new Sports("HN", 3600);
            Clothers s2 = new Sports("DN", 25000);
            Clothers s3 = new Sports("HCM", 35000);
            Clothers s4 = new Sports("QN", 46000);
            Clothers t1 = new Trend("HN", 36000);
            Clothers t2 = new Trend("DN", 36000);
            Clothers t3 = new Trend("HCM", 41000);
            Clothers t4 = new Trend("QN", 18000);
            p1.Showinfor();
            t1.Showinfor();
            s1.Showinfor();
            p1.Sale();
            p2.Sale();
            p3.Sale();
            p4.Sale();
            t1.Sale();
            t2.Sale();
            t3.Sale();
            t4.Sale();
            s1.Sale();
            s2.Sale();
            s3.Sale();
            s4.Sale();
            
        }
    }
}