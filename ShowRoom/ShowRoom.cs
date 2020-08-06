//*************************************************************************************
//use namespace of class Admin because we use the object of Admin in this class
//*************************************************************************************
using Admin1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*************************************************************************************
//use namespace of class Customer because we use the object of Customer in this class
//*************************************************************************************
using Customer1;
//*************************************************************************************
//use namespace of class datastore because we use the object of datastore in this class
//*************************************************************************************
using Data1;
//*************************************************************************************
//use namespace of class Userinterface because we use the object of Userinterface in this class
//*************************************************************************************
using UserInterface1;

namespace ShowRoom1
{
    public class ShowRoom
    {

        Admin ad;
        Customer c;
        UserInterface d1 = new UserInterface();//create the object of class userinterface

        public ShowRoom()
        {
            //Console.WriteLine("from constructor");

            this.ad = new Admin(d1);
            this.c = new Customer(d1);

        }

        public void WelcomeMessege()
        {
            Console.WriteLine("1-Admin");
            Console.WriteLine("2-Customer");
            Console.WriteLine("3-Exit");
            Console.Write("Enter Choice :");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (userchoice == 1)
            {
                ad.WelcomeMessageForAdmin();
                Console.WriteLine("------FINISHED------");
            }
            if (userchoice == 2)
            {
                c.WelcomeMessegeForCustomer();
            }
            Console.ReadLine();


        }
    }
}
