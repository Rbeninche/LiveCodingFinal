using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingFinal
{
    static class Program
    {
        static string[] weatherTypes = new[] { "clear", "cloudy", "Raining", "Full Moon" };

        static string[] temperature = new[] { "40", "50", "60", "70" };

        static double averageKids = 250;

        static double candyPerKids = 3;

        static double weatherPercentage;

        static double temperaturePercentage;



        static double averagePercentage;

        static double totalCandy;
        static void Main(string[] args)
        {
           

           

           
            for(int i = 0; i< weatherTypes.Length; i++)
            {

                for (int j = 0; j < temperature.Length; j++)
                {
                    if (weatherTypes[i] == "clear" && temperature[j] == "50")
                    {
                        
                        weatherPercentage = 0.10;
                        temperaturePercentage = 0;

                        Console.WriteLine("Clear and 50");
                        CalculateQuantityOfCadies();


                    }
                   
                    if (weatherTypes[i] == "Raining" && temperature[j] == "70")
                    {
                        weatherPercentage = -0.25;
                        temperaturePercentage = 0.20;
                        Console.WriteLine("Raining and 70");
                        CalculateQuantityOfCadies();


                    }
                    if (weatherTypes[i] == "Full Moon" && temperature[j] == "40")
                    {
                        weatherPercentage = 0.25;
                        temperaturePercentage = -0.05;
                        Console.WriteLine("Full Moon and 50");
                        CalculateQuantityOfCadies();

                    }


                }
               
            }
           

            Console.ReadLine();
}

        static void CalculateQuantityOfCadies()
        {
            averagePercentage = ((averageKids * weatherPercentage) + (averageKids * temperaturePercentage)) + averageKids;
            totalCandy = averagePercentage * candyPerKids;
            Console.WriteLine("I need to buy " + totalCandy + " candies");
            Console.WriteLine("***********************");

        }


        
        }

   






    }

    
