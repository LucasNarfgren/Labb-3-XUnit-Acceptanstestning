using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_XUnit_Acceptanstestning
{
    public class Subtraktion
    {
        public static void SubtractionCalculator(List<CalcHistory> CalcList)
        {
            Console.Clear();
            Console.WriteLine("---Subtraction---");
            Console.Write("First number: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            double y = double.Parse(Console.ReadLine());
            double sum = Subtraktion.UseSubtraktion(x, y);
            Console.WriteLine("Answer: " + Subtraktion.UseSubtraktion(x, y));
            Console.ReadKey();
            CalcHistory SubtractionSave = new CalcHistory(x, y, sum, "Subtraction"," - ",DateTime.Now);
            CalcList.Add(SubtractionSave);
        }

        public static double UseSubtraktion(double x, double y)
        {
            return x - y;
        }
    }
}
