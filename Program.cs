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
            var weatherTypes = new [] { "clear", "cloudy", "Raining", "Full Moon" };

            var temperature = new [] { "40", "50", "60", "70" };

            double averageKids = 250;

            double candyPerKids = 3;

            double weatherPercentage;

            double temperaturePercentage;



            double averagePercentage;

            double totalCandy;

           

           
            for(int i = 0; i< weatherTypes.Length; i++)
            {

                for (int j = 0; j < temperature.Length; j++)
                {
                    if (weatherTypes[i] == "clear" && temperature[j] == "50")
                    {
                        
                        weatherPercentage = 0.10;
                        temperaturePercentage = 0;
                        averagePercentage = ((averageKids * weatherPercentage) + (averageKids * temperaturePercentage)) + averageKids;
                        totalCandy = averagePercentage * candyPerKids;

                        

                        Console.WriteLine(totalCandy);

                    }
                   
                    if (weatherTypes[i] == "Raining" && temperature[j] == "70")
                    {
                        weatherPercentage = -0.25;
                        temperaturePercentage = 0.20;
                        averagePercentage = ((averageKids * weatherPercentage) + (averageKids * temperaturePercentage)) + averageKids;
                        totalCandy = averagePercentage * candyPerKids;
                        Console.WriteLine(totalCandy);

                    }
                    if (weatherTypes[i] == "Full Moon" && temperature[j] == "40")
                    {
                        weatherPercentage = 0.25;
                        temperaturePercentage = -0.05;
                        averagePercentage = ((averageKids * weatherPercentage) + (averageKids * temperaturePercentage)) + averageKids;
                        totalCandy = averagePercentage * candyPerKids;
                        Console.WriteLine(totalCandy);

                    }


                }
               
            }
           

            Console.ReadLine();


           

            
 
            

        }

     




    }

    



    
}
