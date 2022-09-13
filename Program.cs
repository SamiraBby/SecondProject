using System;

namespace ExamResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLS enter your exam results : ");
            Console.WriteLine(" Your first exam result affect 60% , enter result :");
            double result1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Your first exam result affect 40% , enter result :");

            double result2 =Convert.ToDouble(Console.ReadLine());


             double dec = ExamResult(result1, result2);
            Console.WriteLine($" Your total score : {dec}");
            Decision(dec);

        }
        public static double ExamResult(double result1, double result2)
        {
            double total = (result1 * 60 / 100) + (result2 * 40 / 100);
            return total;
        }
        public static void Decision(double total)
        {
            if (total <= 40 )
            {
                Console.WriteLine(" not passed");
            }
            else if(total > 40)
            {
                Console.WriteLine("passed");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
