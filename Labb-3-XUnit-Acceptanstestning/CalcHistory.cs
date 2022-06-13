using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_XUnit_Acceptanstestning
{
    public class CalcHistory
    {
        public double x { get; set; }
        public double y { get; set; }
        public double Summary { get; set; }
        public string TypeofCalc { get; set; }
        public string Type { get; set; }
        public DateTime date { get; set; }
        public CalcHistory()
        {

        }
        public CalcHistory(double X,double Y,double summary,string typeofcalc,string type,DateTime Date)
        {
            this.x = X;
            this.y = Y;
            this.Summary = summary;
            this.TypeofCalc = typeofcalc;
            this.Type = type;
            this.date = DateTime.Now;
        }

        public static void PrintCalculations(List<CalcHistory> CalcList)
        {
            Console.Clear();
            Console.WriteLine("---Calculations---\n");
            foreach (var item in CalcList)
            {
                Console.WriteLine(item.TypeofCalc);
                Console.WriteLine($"{item.date} | {item.x}{item.Type}{item.y} = {item.Summary}\n");
            }
            Console.ReadKey();
        }
    }
}
