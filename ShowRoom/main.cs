using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//************************************************************************
//use namespace of class Showroom because we use the object of Showroom in this clas
//************************************************************************
using ShowRoom1;


namespace Car_Management_System
{
    class main
    {

        static void Main(string[] args)
        {

            Console.WriteLine("\t*********************************************************************************************************");
            Console.WriteLine("\t*********************************************************************************************************");
            Console.WriteLine("\t| |    ||     | |  _______            _________   ___________   ______      ______    _______ ");
            Console.WriteLine("\t| |   || ||   | | | ______| | |      |  _______| |  _______  | | |||||      ||||  |  | ______|");
            Console.WriteLine("\t| |  ||   ||  | | ||______  | |      | |         | |       | | | |   ||    ||   | |  ||______ ");
            Console.WriteLine("\t| | ||     || | | | ______| | |      | |         | |       | | | |    ||  ||    | |  | ______|");
            Console.WriteLine("\t|||||       ||||| ||______  | |____  | |_____    | |_______| | | |     ||||     | |  ||______ ");
            Console.WriteLine("\t|___|       |___| | ______| |______| |_________| |___________| | |      ||      | |  |_______|");
            Console.WriteLine("\t*********************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("\t**********************************     TO SHOW ROOM     *************************************************");
            Console.WriteLine();
            Console.WriteLine("\t*********************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\tGROUP MEMBERS:");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t**************************************");
            Console.WriteLine("\t\t\t\tAbubaker Ijaz        ADPCS-S02-F19-031");
            Console.WriteLine("\t\t\t\tFida Alvi Maryam     ADPCS-S02-F19-019");
            Console.WriteLine("\t\t\t\tFariha               ADPCS-S02-F19-012");
            Console.WriteLine("\t\t\t\tMuhammad Adil        ADPCS-S02-F19-035");
            Console.WriteLine("\t\t\t\t**************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t\t\t\tTo:");

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\tProf. Ishtiaq Rai");


            Console.ReadLine();
            Console.Clear();
            ShowRoom showRoom = new ShowRoom();
            showRoom.WelcomeMessege();
        }
    }
}
