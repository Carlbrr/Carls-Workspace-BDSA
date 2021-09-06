using System;

namespace HelloThere
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type a year and press the Enter key: ");
            Console.WriteLine("- note that you must input a year above 1582 in a four digit format: yyyy");
            try{
                int year = Convert.ToInt32(Console.ReadLine());
                if(year < 1582){
                    throw new ArgumentException("The typed year must be above 1582"); 
                }
                if(isLeapYear(year)){
                    Console.WriteLine("yay");
                }else{
                    Console.WriteLine("nay");
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
                Console.Write(" - Try again!");
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
