using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class ArrayEx
    {
        public static void Run()
        {
            //string[] fraudulentOrderIDs = new string[3];

            //fraudulentOrderIDs[0] = "A123";
            //fraudulentOrderIDs[1] = "B456";
            //fraudulentOrderIDs[2] = "C789";
            string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

        }
    }
}
