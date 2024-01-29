using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekend_weekdays_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the day:");
            string dayName = Console.ReadLine();

            switch (dayName)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    Console.WriteLine("Weekday");
                    Console.ReadKey();
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("Weekend");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid input ");
                    Console.ReadKey();
                    break;
                 

            }
        }
    }
}
