using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ReservationManager
{
    class Restaurant
    {
        //Array Multi-dimensional array representing restaraunt with number of tables for hours of operation
        private bool[][] HoursOfOperation { get; set; }

        //Constructor for the Restaurant
        public Restaurant(bool[][] hoursOfOperation)
        {
            HoursOfOperation = hoursOfOperation;


        }

        public void PrintRestaurant()
        {
            //iterates through outside array elements
            for (int i = 0; i < HoursOfOperation.Length; i++)
            {
                // Test to print outside Array Elements
                Console.Write("\n Hour[{0}]: ", i);


                //iterates through each array within outside element
                for (int j = 0; j < HoursOfOperation[i].Length; j++)
                {
                    //prints all inside elements for each outside element
                    Console.Write("{0}{1} ", HoursOfOperation[i][j], j == (HoursOfOperation[i].Length - 1) ? "" : " ");

                }
                Console.WriteLine();
            }

        }
        public string MakeReservation(int hour, int numOfTables)
        {
            //initialize return value
            string reservation = null;
           
            //Business hours
            int open = 1;
            int close = 8;
           
            //variable initialized that will be decremented to tay inline with LINQ Statement
            int tableIndex = numOfTables;

            //Checks Input time against business hours
            if (hour >= open && hour <= close)
            {
                //iterates outer loop that represents business hours
                for(int i = 0; i < HoursOfOperation.Length; i++)
                {
                    // checks hour passed and when iteration reaches hour in outer loop it stops
                    if(hour == i+1)
                    {
                        // iterates through inner loop at element == hour passed
                        for (int j = 0; j < HoursOfOperation[i].Length; j++)
                        {
                            //checl number of tables against size of restaurant
                            if (numOfTables <= 10)
                            {
                                // intitializes variable which represents the count of total bools that are equal to false
                                int available = HoursOfOperation[i].Where(c => c == false).Count();

                                //Checks operation of LINQ Statement
                                //Console.WriteLine(available);

                                //Use decrementer against available to insure number of tables requested do not exeed number of tables still available
                                if (tableIndex <= available)
                                {
                                    //sets value at index[numOfTables] and each value previous until element 0 to true ("reserved")
                                    if (numOfTables - 1 >= j)
                                    {
                                        HoursOfOperation[i][j] = true;
                                        reservation = "Table available\nReservation set";
                                        tableIndex--;
                                    }


                                }
                                //uses decrementer against tables available to see if number requested  does exceed number of open tables for that time.
                                if (tableIndex > available)
                                {
                                    reservation = "Number requested exceeds available for hour selected\n Please Select different time";
                                }

                            }
                            //value returned if number of tables requested are greater than total size of restaurant
                            else
                                reservation = "Number requested exceeds size of restaurant";                          



                        }
                    }
                    

                }
                
            }
            //value paassed if hour requested is outside of business hours
            else
                reservation = "Closed";


            return reservation;   
        }
       
        // method that will print total number of reservations for the day. Created for possible use later
        public string GetNumberOfBools()
        {
            int count = 0;
            

            for (int i = 0; i < HoursOfOperation.Length; i++)
            {
                for (int j = 0; j < HoursOfOperation[i].Length; j++)
                {
                    if (HoursOfOperation[i][j] == true)
                        count++;
                    
                }
            }
            return $"\n{count} Total Reservations So far\n";

        }
        public string CancelReservation(int hour, int numOfTables)
        {
            //initialize return value
            string reservation = null;

            //Business hours
            int open = 1;
            int close = 8;

            //variable initialized that will be decremented to tay inline with LINQ Statement
            int tableIndex = numOfTables;

            //Checks Input time against business hours
            if (hour >= open && hour <= close)
            {
                //iterates outer loop that represents business hours
                for (int i = 0; i < HoursOfOperation.Length; i++)
                {
                    // checks hour passed and when iteration reaches hour in outer loop it stops
                    if (hour == i + 1)
                    {
                        // iterates through inner loop at element == hour passed
                        for (int j = 0; j < HoursOfOperation[i].Length; j++)
                        {
                            //checl number of tables against size of restaurant
                            if (numOfTables <= 10)
                            {
                                // intitializes variable which represents the count of total bools that are equal to false
                                int available = HoursOfOperation[i].Where(c => c == true).Count();

                                //Checks operation of LINQ Statement
                                //Console.WriteLine(available);

                                //Use decrementer against available to insure number of tables requested do not exeed number of tables still available
                                if (tableIndex <= available)
                                {
                                    //sets value at index[numOfTables] and each value previous until element 0 to true ("reserved")
                                    if (numOfTables - 1 >= j)
                                    {
                                        HoursOfOperation[i][j] = false;
                                        reservation = "Reservation Canceled";
                                        tableIndex--;
                                    }


                                }
                                //uses decrementer against tables available to see if number requested  does exceed number of open tables for that time.
                                if (tableIndex > available)
                                {
                                    reservation = "Reservation Does not exist";
                                }

                            }
                            //value returned if number of tables requested are greater than total size of restaurant
                            else
                                reservation = "Check your request. Number of tables too large";



                        }
                    }


                }

            }
            //value paassed if hour requested is outside of business hours
            else
                reservation = "Closed";


            return reservation;
        }


        //)




        /*public void PrintRestaurant()
        {

            for (int i = 0; i < HoursOfOperation.Length; i++)
            {
                
                for (int j = 0; j < HoursOfOperation.Length; j++)
                {
                    Console.Write("Hour [{0}]\n Table [{1}]", i, j);
                                      

                }
            }
        }*/
        /* public string MakeReservation(int hour, int numOfTables)
         {


             // varriable to return to user. should let user no if tables requested were available and if reservation was made or not



             //Outside for loop to iterate through the array holding each hour of tables
             /*for (int i = 0; i < HoursOfOperation.GetLength(0); i++)
             {
                 //inside for loop to iterate the array at each element
                 for(int j = 0; j < HoursOfOperation.GetLength(1); j++)
                 {






                 }

             }
             return ;*/

    }

}


