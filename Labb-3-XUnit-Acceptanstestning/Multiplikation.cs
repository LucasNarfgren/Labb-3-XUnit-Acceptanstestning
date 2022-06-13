using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_XUnit_Acceptanstestning
{
    public class Multiplikation
    {
        public static void MultiplicationCalculator(List<CalcHistory> CalcList)
        {
            Console.Clear();
            Console.WriteLine("---Multiplication---");
            Console.Write("First number: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            double y = double.Parse(Console.ReadLine());
            double sum = Multiplikation.UseMultiplikation(x, y);
            Console.WriteLine("Answer: " + Multiplikation.UseMultiplikation(x, y));
            Console.ReadKey();
            CalcHistory MultiplicationSave = new CalcHistory(x, y, sum, "Multiplication", " * ", DateTime.Now);
            CalcList.Add(MultiplicationSave);
        }

        public static double UseMultiplikation(double x, double y)
        {
            return x * y;
        }
    }
}
