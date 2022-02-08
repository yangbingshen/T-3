// C# program to convert canadian dollar to US$
// Bingshen Yang
// 02/08/2022
using System;

namespace T_3
{
    class Program
    {
        public static void Main()
        {
           
            int inc_value;

           
            while (true)
            {
               
                Console.Write("Enter increament value between 5 and 25 :");
                inc_value = Convert.ToInt32(Console.ReadLine());
                
                if (inc_value >= 5 && inc_value <= 25)
                {
                    break;
                }
                
                Console.WriteLine("increament value must be between 5 and 25,, try again");
            }

            
            double CAD = 0, USD;

            Console.WriteLine("CAD   US$");
            Console.WriteLine("-------------");

           
            do
            {
              
                USD = CAD * 0.792367;
             
                Console.WriteLine(CAD + "    " + USD);

              
                CAD += inc_value;
            }
            while (CAD <= 200);
        }
    }
}
