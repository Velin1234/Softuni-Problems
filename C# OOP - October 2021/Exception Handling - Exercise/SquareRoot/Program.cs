using System;

namespace SquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                SquareRootOfN(n);
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
        public static void SquareRootOfN(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Invalid number");
            }
            Console.WriteLine(Math.Sqrt(n));
        }
    }
}
