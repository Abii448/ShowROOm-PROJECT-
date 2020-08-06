//*************************************************************************************
//use namespace of class datastore because we use the object of datastore in this class
//*************************************************************************************
using Data1;
//*************************************************************************************
//use namespace of class ShowRoom because we use the object of ShowRoom in this class
//*************************************************************************************
using ShowRoom1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*************************************************************************************
//use namespace of class Userinterface because we use the object of Userinterface in this class
//*************************************************************************************
using UserInterface1;

namespace Customer1

{
    public class Customer
    {
        private UserInterface d2;//class sharing but no new object is created

        public Customer(UserInterface d)
        {
            this.d2 = d;
        }

        public Customer() { }
        //ShowRoom room = new ShowRoom();
        public void WelcomeMessegeForCustomer()
        {
            Console.WriteLine("1-Direct Payment");

            Console.WriteLine("2-Exit From Customer");


            Console.Write("Enter Choice :");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (userchoice == 1)

            {
                //  d.ShowCars();
                Console.Write("Enter your Car Name :");
                string Car_name = Console.ReadLine();
                Console.Write("Enter your name : ");
                string name = Console.ReadLine();
                Console.Write("Enter CNIC number :");
                string CNIC_number = Console.ReadLine();
                Console.Write("Enter phone number :");
                String Phone_number = Console.ReadLine();
                //d.purchaseCar();
                Console.WriteLine("You purchaase car successfully");
            }

            if (userchoice == 2)
            {
                return;
            }




        }
    }
}
