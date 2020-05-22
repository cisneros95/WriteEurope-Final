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


        static void DisplaySum() // This is the method definition
        {
            // Problem 1 WriteAverage
            Double num01 = 2.0;
            Double num02 = 7;
            Console.WriteLine("{0} + {1} / 2 = {2}", (num01 + num02) / 2);  /// this method works!!
        }


        static void DisplayWriteEurope() //test is a parameter
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





