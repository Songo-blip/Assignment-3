using System;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            int num;
            int nextdigit;
            int numdigit;

            int[] n = new int[20];
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers entered in words");
            nextdigit = 0;
            numdigit = 0;

            do

            {
                nextdigit = num % 10;
                n[numdigit] = nextdigit;
                numdigit++;
                num = num / 10;
            }
            while (num > 10);
            numdigit--;
            for (; numdigit >= 0; numdigit--)
                Console.WriteLine(digits[n[numdigit]] + "");
            Console.WriteLine();
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
