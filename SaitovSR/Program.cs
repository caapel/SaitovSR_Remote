namespace SaitovSR
{
    //Saitov Stanislav Radicovich, T-2-09
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sqr(5));
            //solve task2
        }

        static public double Sqr(double X)
        { 
            return Math.Pow(X, 2);
        }
    }
}
