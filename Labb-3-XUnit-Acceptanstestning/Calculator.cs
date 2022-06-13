using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_XUnit_Acceptanstestning
{
    

    public class Calculator
    {
        
        public static void CalculatorRun()
        {
            List<CalcHistory> CalcList = new List<CalcHistory>();
            Console.WriteLine("Calculator Edition v2.3.7");
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
            bool ActiveMenu = true;
            do
            {
                Console.Clear();
                Console.WriteLine("What do you want to Calculate?\n");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Calculations");
                Console.WriteLine("0. Exit");
                int menu = 10;
                try
                {
                    menu = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose a number in the list");
                    Console.ReadKey();
                }
                switch (menu)
                {
                    case 1:
                        Addition.AdditionCalculator(CalcList);
                        break;
                    case 2:
                        Subtraktion.SubtractionCalculator(CalcList);
                        break;
                    case 3:
                        Multiplikation.MultiplicationCalculator(CalcList);
                        break;
                    case 4:
                        Division.DivisionCalculator(CalcList);
                        break;
                    case 5:
                        CalcHistory.PrintCalculations(CalcList);
                        break;
                    case 0:
                        Environment.Exit(1);
                        break;
                }
            } while (ActiveMenu);
        }
    }
}
