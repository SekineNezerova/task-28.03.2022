using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Car : motoredVehicle
    {
        public string IsOn;

        public int TurnOn(bool IsOn)
        {
            if (IsOn == true)
                return 1;
            else
                return 0;
        }
        public void TurnOff()
        {
         
        }


        public Car()
        {

        }
        public int Go(int FuelTankSize, int FuelAmount, int FuelUsedPerKm)
        {
            int distance;
            if (FuelTankSize == FuelAmount)
            
                distance = FuelAmount / FuelUsedPerKm;
                return FuelAmount / FuelUsedPerKm;
            
            
            



        }





        public Car(string model, string make, string ProductionYear) : base(model, make, ProductionYear)
        {

        }


    }
}
