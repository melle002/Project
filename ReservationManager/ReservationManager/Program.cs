using System;

namespace ReservationManager
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[][] hoursOfOperation =
            {
                new bool[10],
                new bool[10],
                new bool[10],
                new bool[10],
                new bool[10],
                new bool[10],
                new bool[10],
                new bool[10],
            };
            Restaurant restaurant = new Restaurant(hoursOfOperation);






            Console.WriteLine("______________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("                               Welcome to Eller's Reservation System                                          ");
            Console.WriteLine("______________________________________________________________________________________________________________");



            //---------------------CREATE A STRING WRITER TO REPLACE ALL CONSOLE.WRITELINE INSTANCES---------------------------------//
            l1:

            Console.WriteLine("______________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("     1|New Reservation   2|Cancel Reservation   3|Change Reservation   4|Print Restaurant Status   5|Exit     ");
            Console.WriteLine("______________________________________________________________________________________________________________");

            //--------------------------------------------------------------------------------------------------------------------------// 

            Console.Write(" Please Make a Selection:  ");
            var response = Console.ReadLine();
            Console.WriteLine("_______________________________________________________________________________________________________________");
            
            switch (response)
            {

                case "1":

                    //Supplies User instructions for selecting Reservation Time
                    Console.WriteLine($"Please Enter 1-8 For Reservation Time:  ");
                    
                    //Declares time variable from User input
                    var time = int.Parse(Console.ReadLine());

                    //Supplies User instructions for selecting the number of tables needed for reservation
                    Console.WriteLine("Please select number of tables requested:  ");

                    //Declares variable that represents the number of tables requested for the reservation
                    var numOfTables = int.Parse(Console.ReadLine());
                    
                    //Call to Reserve Method using previosly declared variables for parameters
                    Console.WriteLine(restaurant.MakeReservation(time, numOfTables));

                    //Checks function of Method and prints bool

                    goto l1;

                case "2":
                    //Supplies User instructions for selecting Reservation Time
                    Console.WriteLine($"Please Enter 1-8 For Reservation Time: ");

                    //Declares time variable from User input
                    time = int.Parse(Console.ReadLine());

                    //Supplies User instructions for selecting the number of tables needed for reservation
                    Console.WriteLine("Please select number of tables requested: ");

                    //Declares variable that represents the number of tables requested for the reservation
                    numOfTables = int.Parse(Console.ReadLine());

                    Console.WriteLine(restaurant.CancelReservation(time, numOfTables));
                    goto l1;
                    



                case "3":
                    //ChangeReservation();
                    Console.WriteLine("Still Under Construction. Check Back Later!");
                    goto l1;

                case "4":
                    restaurant.PrintRestaurant();
                    Console.WriteLine(restaurant.GetNumberOfBools());
                    goto l1;

                case "5":
                    Console.WriteLine("Good Bye!");
                    Environment.Exit(0);
                   
                    break;


                    default:
                        Console.WriteLine("Sorry, invalid selection.");
                    goto l1;
                        

            }




        }
    }
}
