using System;

namespace DSA
{
    class KrishnamurthyKrishnamurthy
    {
        public static int Fact(int digit)
        {
            if (digit == 0 || digit == 1)
                return 1;
            return digit * Fact(digit - 1);
        }

        public static bool CheckKrishnamurthy(int n)
        {
            int sum = 0;
            int original = n;

            while (n != 0)
            {
                int digit = n % 10;
                sum += Fact(digit);
                n = n / 10;
            }

            return sum == original;
        }

        static void Main(string[] args)
        {
            int n = 145;
            if (Krishnamurthy.CheckKrishnamurthy(n))
            {
                Console.WriteLine("Krishnamurthy");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy");
            }
        }
    }
}
