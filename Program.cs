using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weatherTypes = { "clear", "cloudy", "Raining", "Full Moon" };

            string[] temperature = { "40", "50", "60", "70" };

            int averageCandy = 250;

            int candyPerKid = 3;

            

            double percentage = 0;

            double moreTricks = averageCandy * percentage;

            double totalCandy = averageCandy * candyPerKid + moreTricks; 

            for(int i = 0; i < weatherTypes.Length; i++)
            {
               if(weatherTypes[i] == "Clear")
                {
                    percentage = 0.10;
                }

            }

            

        }
    }
}
