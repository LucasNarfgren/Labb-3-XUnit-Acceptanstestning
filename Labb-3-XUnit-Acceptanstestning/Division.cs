using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_XUnit_Acceptanstestning
{
    public class Division
    {
        public static void DivisionCalculator(List<CalcHistory> CalcList)
        {
            Console.Clear();
            Console.WriteLine("---Division---");
            Console.Write("First number: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            double y = double.Parse(Console.ReadLine());
            double sum = Division.UseDivision(x, y);
            Console.WriteLine("Answer: " + Division.UseDivision(x, y));
            Console.ReadKey();
            CalcHistory DivisionSave = new CalcHistory(x, y, sum, "Division", " / ", DateTime.Now);
            CalcList.Add(DivisionSave);
        }

        public static double UseDivision(double x, double y)
        {
            return x / y;
        }
    }
}
