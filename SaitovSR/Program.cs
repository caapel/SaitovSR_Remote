namespace SaitovSR
{
    //Saitov Stanislav Radicovich, T-2-09
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sqr(5));
        }

        static public double Sqr(double X)
        { 
            return Math.Pow(X, 2);
        }
    }
}
