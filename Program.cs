using System.Security.Cryptography;

namespace EuclideanAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 156;
            int b = 66;

            int gCD = EuclideanAlgorithm(a, b);
            Console.WriteLine($"Greatest common divisor of {a} and {b} is {gCD}");
        }

        public static int EuclideanAlgorithm(int a, int b)
        {
            if(a == 0)
            {
                return b;
            }
            if(b == 0)
            {
                return a;
            }

            int wieoftpasstBinA = a / b; //how often does B in A fit
            int rest = a % b;

            if (rest <= 0)
            {
                return b;
            }

            return EuclideanAlgorithm(b, rest);
        }
    }
}