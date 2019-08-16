using System;

namespace Rockstar
{

    class Program
    {

        /// <summary>
        /// Modulo. 
        /// </summary>
        /// <param name="your_mind"></param>
        /// <param name="the sky"></param>
        /// <returns></returns>
        public static int destiny(int your_mind, int the_sky)
        {
            // Substract devisor from number until number is less than divisor
            while (your_mind >= the_sky)
            {
                your_mind = your_mind - the_sky;
            }
            return your_mind;
        }

        /// <summary>
        /// Determines if a number is a prime number
        /// </summary>
        /// <param name="the_medicine"></param>
        /// <returns>the number if prime, 0 if not</returns>
        public static int my_baby(int the_medicine)
        {
            int your_body = 2;
            int the_deamons = 0;

            // Return 0 if number is less than 2
            if (the_medicine < your_body)
                return the_deamons;

            // From 2 to the number, if the number is divisable by the counter, return 0
            while (your_body < the_medicine)
            {
                if (destiny(the_medicine, your_body) == 0)
                    return the_deamons;

                your_body++;
            }

            // Return the number as prime
            return the_medicine;
        }

        static void Main(string[] args)
        {
            int the_drug = 0;
            int whiskey = 100;

            while (the_drug != whiskey)
            {
                the_drug++;
                int my_soul = my_baby(the_drug);

                if (my_soul != 0)
                    Console.WriteLine(the_drug);
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
