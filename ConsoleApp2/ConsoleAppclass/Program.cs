using System;

namespace Classes
{
    class Program:Car
    {
        static void Main(string[] args)

        {
            motoredVehicle motored = new motoredVehicle();
            motored.ProductionYear = "2010";
            motored.model = "Mercedes";
            motored.make = "s500";
            Console.WriteLine($"{motored.ProductionYear}-{motored.model}-{motored.make}");

            Car car = new Car();
            car.FuelAmount = 55;
            car.FuelTankSize = 55;
            car.FuelUsedPerKm = 11;
            
           
            

        }

      


        }
    }

