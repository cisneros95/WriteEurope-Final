using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteAmerican
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplaySum(); // This is the method call
            DisplayWriteEurope();

        }


        static void DisplaySum(int num01, int num02) // This is the method definition
        {
            // Problem 1 WriteAverage
            Double numb01 = 2.0;
            Double numb02 = 7;


            Console.WriteLine("{0} + {1} / 2 = {2}", (numb01 + numb02) / 2);  /// this method works!!
        }


        static void DisplayWriteEurope()
        {

            // Problems 2,3 WriteEuropen and Problems 4,5 WriteAmerican
            String day = "Saturday,"; // String one day = Saturday
            String month = "July";    // Sting month = July
            int year = (2020);        // int year = 2020
            int date = (18);          // int day = to the 18th

            Console.WriteLine(day + " " + month + " ", date + ',' + " " + year);

        }
    }
}
