using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//************************************************************************
//use namespace of class car because we use the object of Car in this clas
//************************************************************************
using Car1;
namespace Data1
{
    public class DataStore
    {
        //*****************************************************************
        //we create car type array bcz we use class as a data type
        //*****************************************************************
        public Car[] c1;
        public int count = 0;
        //***********
        //Constructor
        //***********
        public DataStore()
        {

            c1 = new Car[50];

        }
        //function 
        //***********************************************
        //Getting array index thiS method 
        //shpuld be private Bcz we not need to use this method to and another class
        //************************************************
        private int GetIndex(string plate)
        {
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                if (c1[i].CarPlate == plate)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        //******************************************************************
        //this method provide the index or array or abstraction(hiding Data)
        //******************************************************************
        public void AddCar(Car c)
        {
            c1[count] = c;
            count++;
        }
        //******************************************************
        //this method provide the index in which we search a car,
        ////get the index which one car is place oR abstraction
        //******************************************************
        public Car SearchCar(string plate)
        {
            Car result = null;
            for (int i = 0; i < count; i++)
            {
                if (c1[i].CarPlate == plate)
                {
                    result = c1[i];
                    break;
                }
            }
            return result;
        }
        //************************************************************************
        //by using getindex method we get index and the dlt the car on that index
        //***********************************************************************
        public void DeleteCar(string plate)
        {
            Car c = SearchCar(plate);
            c = null;
            int n = GetIndex(plate);
            for (int i = n; i < count; i++)
            {
                c1[i] = c1[i + 1];
            }
            count--;
            Console.WriteLine("Car Deleted successfully from the database");
        }//get the index in which we want to delete car or abstraction
        //**********************************************
        //get index by using getindex method and then update the caR
        //******************************************************
        public void UpdateCar(string plate, Car c)
        {
            int i = GetIndex(plate);
            c1[i] = c;
        }




    }
}
