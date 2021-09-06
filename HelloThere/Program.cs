using System;

namespace HelloThere
{
    public class Program
    {
        public static void Main(string []args)
        {
            Console.WriteLine("Please enter a year and press the Enter key: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if(isLeapYear(year)){
                Console.WriteLine("yay");
            }else{
                Console.WriteLine("nay");
            }

        }
        public static bool isLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        return true;
                    }else
                    {
                      return false;  
                    }  
                }else
                {
                    return true;
                }
            }else
            {
                return false;
            }

        }
        
   
    }
}
