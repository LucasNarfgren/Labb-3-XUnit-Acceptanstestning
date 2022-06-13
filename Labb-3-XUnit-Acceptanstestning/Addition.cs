using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_XUnit_Acceptanstestning
{
    public class Addition
    {
        public static void AdditionCalculator(List<CalcHistory> CalcList)
        {
            Console.Clear();
            Console.WriteLine("---Addition---");
            Console.Write("first number: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            double y = double.Parse(Console.ReadLine());
            double sum = Addition.UseAddition(x, y);
            Console.WriteLine("Answer: " + Addition.UseAddition(x, y));
            Console.ReadKey();
            CalcHistory AdditionSave = new CalcHistory(x, y, sum, "Addition"," + ",DateTime.Now);
            CalcList.Add(AdditionSave);
        }

        public static double UseAddition(double x, double y)
        {
            return x + y;
        }
    }
}
