using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car1
{
    public class Car
    {
        public string CarBrand;
        public string CarModel;
        public string CarPlate;
        public string CarEngine;
        public string fuelCapacity;
        public float CarPurchasePrice;
        public float CarSalePrice;
        //******************************
        //parameterize Constructor
        //******************************
        public Car(string carBrand, string carModel, string carPlate, string carEngine, float carPurchasePrice, float carSalePrice, string fuelCapacity = "")
        {
            this.CarBrand = carBrand;
            this.CarModel = carModel;
            this.CarPlate = carPlate;
            this.CarEngine = carEngine;
            this.CarPurchasePrice = carPurchasePrice;
            this.CarSalePrice = carSalePrice;
            this.fuelCapacity = fuelCapacity;
        }
        //******************************
        // withoUt parameterize Constructor 
        //******************************
        public Car()
        {

        }

    }
}
