using System;

namespace Rockstar
{

    class Program
    {

        /// <summary>
        /// Determines if a number is a prime number
        /// </summary>
        /// <param name="the_medicine"></param>
        /// <returns>the number if prime, 0 if not</returns>
        public static int my_baby(int the_medicine)
        {
            int your_body = 2;
            int the_deamons = 0;

            // Return 0 is number is less than 2
            if (the_medicine < your_body)
                return the_deamons;

            // From 2 to the number, if the number is divisable by the counter, return 0
            while (your_body != the_medicine)
            {
                if (destiny(the_medicine, your_body) == 0)
                    return the_deamons;

                your_body++;
            }

            // Return the number as prime
            return the_medicine;
        }

        /// <summary>
        /// Modulo. 
        /// </summary>
        /// <param name="your_love"></param>
        /// <param name="your_mind"></param>
        /// <returns></returns>
        public static int destiny(int your_love, int your_mind)
        {
            // Substract second number from first until the result is less than the first
            while (your_love >= your_mind)
            {
                your_love -= your_mind;
            }
            return your_love;
        }



        static void Main(string[] args)
        {
            int the_drugs = 0;
            int whiskey = 100;

            while (the_drugs != whiskey)
            {
                the_drugs++;
                int my_soul = my_baby(the_drugs);

                if (my_soul != 0)
                    Console.WriteLine(the_drugs);
            }

        }

        //public static bool FindPrime(int n)
        //{
        //    if (n <= 1) return false;
        //    if (n == 2) return true;
        //    if (n % 2 == 0) return false;

        //    for (int i = 3; i < n; i += 2)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
    }
}
