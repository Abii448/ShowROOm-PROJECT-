

//*************************************************************************************
//use namespace of class datastore because we use the object of datastore in this class
//*************************************************************************************
using Data1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//************************************************************************
//use namespace of class car because we use the object of Car in this clas
//************************************************************************
using Car1;

namespace UserInterface1
{
    public class UserInterface
    {
        //***************************************
        //create object of datastore class
        //***************************************
        public DataStore d = new DataStore();

        public void ShowCars()
        {
            Console.WriteLine("Car Brand    car model   sale price  plate");
            Console.WriteLine(d.c1[0].CarBrand);
            for (int i = 0; i < d.count; i++)
            {

                Console.WriteLine(d.c1[i].CarBrand);
                Console.WriteLine(d.c1[i].CarModel);
                Console.WriteLine(d.c1[i].CarEngine);
                Console.WriteLine(d.c1[i].CarPlate);
            }
        }
        //*******************************************
        //uSer interfaernece to addcar
        //*******************************************
        public void AddCar()
        {
            Console.Write("Enter Car Brand:");
            string brand = Console.ReadLine();
            Console.Write("Enter Car Model:");
            string model = Console.ReadLine();
            Console.Write("Enter Car Registration Plate No:");
            string plate = Console.ReadLine();
            Console.Write("Enter Car Engine No:");
            string Engine = Console.ReadLine();
            Console.Write("Enter Car purchase Price:");
            float PurchasePrice = float.Parse(Console.ReadLine());
            Console.Write("Enter Car sale Price:");
            float saleprice = float.Parse(Console.ReadLine());
            Car c = new Car(brand, model, plate, Engine, PurchasePrice, saleprice);
            d.AddCar(c);
        }
        //*******************************************
        //uSer interfaernece to Search Car
        //*******************************************
        public void SearchCar()
        {
            Console.Write("Enter Registartion No Of Car To Search:");
            string plate = Console.ReadLine();
            Car c = d.SearchCar(plate);
            if (c != null)
            {
                Console.WriteLine(c.CarBrand);
                Console.WriteLine(c.CarModel);
                Console.WriteLine(c.CarEngine);
                Console.WriteLine(c.CarPlate);
                Console.WriteLine(c.CarPurchasePrice);
                Console.WriteLine(c.CarSalePrice);
            }
            else
            {
                Console.WriteLine("Car not found");
            }
        }
        //*******************************************
        //uSer interfaernece to update Car
        //*******************************************
        public void UpdateCar()
        {
            Console.WriteLine(" Enter Registration No to update the car details:");
            string toUpdateplate = Console.ReadLine();
            Car c = d.SearchCar(toUpdateplate);
            if (c == null)
            {
                Console.WriteLine("Car Not Found. ");
                return;
            }
            else
            {
                Console.Write("Enter Car Brand:");
                string brand = Console.ReadLine();
                Console.Write("Enter Car Model:");
                string model = Console.ReadLine();
                Console.Write("Enter Car Registration Plate No:");
                string plate = Console.ReadLine();
                Console.Write("Enter Car Engine No:");
                string Engine = Console.ReadLine();
                Console.Write("Enter Car purchase Price:");
                float PurchasePrice = float.Parse(Console.ReadLine());
                Console.Write("Enter Car purchase Price:");
                float saleprice = float.Parse(Console.ReadLine());
                Car c1 = new Car(brand, model, plate, Engine, PurchasePrice, saleprice);
                d.UpdateCar(toUpdateplate, c1);
            }


        }
        //*******************************************
        //user interface to delete car
        //*******************************************
        public void DeleteCar()
        {
            Console.Write("Enter Registartion No Of Car To Search:");
            string plate = Console.ReadLine();
            d.DeleteCar(plate);
        }

    }
}
