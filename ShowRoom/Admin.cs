using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//************************************************************************
//use namespace of class DataStore because we use the object of Datastore in this clas
//************************************************************************
using Data1;
//************************************************************************
//use namespace of class car because we use the object of Car in this clas
//************************************************************************
using Car1;
//************************************************************************
//use namespace of class  ShowRoom because we use the object of ShowRoom in this clas
//************************************************************************
using ShowRoom1;
using UserInterface1;

namespace Admin1
{
    public class Admin
    {
        private UserInterface User; //this is use for sharing database
                                    //but no new object is created just we get
                                    //the refrnce of class interface
        public Admin(UserInterface d)
        {
            this.User = d;
        }
        public Admin() { }

        public void WelcomeMessageForAdmin()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1- Add a car");
                Console.WriteLine("2- Search a car");
                Console.WriteLine("3- Delete a car");
                Console.WriteLine("4- Update a car");
                Console.WriteLine("5- Exit");
                Console.Write("Enter Choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        User.AddCar();
                        break;
                    case 2:
                        User.SearchCar();
                        break;
                    case 3:
                        User.DeleteCar();
                        break;
                    case 4:
                        User.UpdateCar();
                        //User.ShowCars();
                        break;
                    case 5:

                        ShowRoom r = new ShowRoom();
                        r.WelcomeMessege();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice !");
                        break;

                }
            } while (choice != 7);
        }

    }
}
