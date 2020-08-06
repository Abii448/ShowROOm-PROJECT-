using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*************************************************************************************
//use namespace of class car because we use the object of Car in this class
//*************************************************************************************
using Car1;


namespace Electric_Car
{
    public class ElectricCar : Car
    {
        public string BatteryCapacity { get; set; }
        public ElectricCar(string carBrand, string carModel, string carPlate, string carEngine, float carPurchasePrice, float carSalePrice, string batteryCapacity) : base(carBrand, carModel, carPlate, carEngine, carPurchasePrice, carSalePrice)
        {
            this.BatteryCapacity = batteryCapacity;
        }
    }
}
