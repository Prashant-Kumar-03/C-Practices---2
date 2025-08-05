using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class ForEachChallenge
    {
        public static void Run()
        {
            string[] fraudOrderId = { "B123","C234","A345", "C15", "B177", "G3003", "C235", "B179" };
            foreach(string id in fraudOrderId){
                if(id.StartsWith("B"))
                {
                    Console.WriteLine($"Fraudulent order ID: {id}");
                }
            }

        }
    }
}
