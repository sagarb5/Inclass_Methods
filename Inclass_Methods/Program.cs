using System;

namespace Inclass_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you age b/w 18 and 100");
            try
            {
                string input = Console.ReadLine();
                int age_value = int.Parse(input);

                if (age_value > 17 && age_value <= 100)
                {
                    int get_max_heart_rate = Max_Heart_Rate(age_value);
                    Console.WriteLine("Max Heart rate is " +get_max_heart_rate);
                }// end of if




                // exit statement
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }// end of try
            catch
            {
                Console.WriteLine("Please enter an integer value for your age next time ...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // end of catch
        }// end of main

        private static int Max_Heart_Rate(int get_age) // name of the method should be a capital letter
        {
            int cal_max_heart_rate = 220 - get_age;
            // Console.WriteLine("Acc. to Your age the max heart rate should be =  " + cal_max_heart_rate);

            return cal_max_heart_rate;
        }
    }
}
