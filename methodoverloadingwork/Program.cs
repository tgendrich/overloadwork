using System;

namespace methodoverloadingwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"{Add(4,4)} is the first add method");
            Console.WriteLine($"{Add(2m,2m)} is the second add method");
            Console.WriteLine($"{Add(4,9,true)} is the third add method");
        
        
        }
    
        public static int Add(int a, int b)
        {
            return a + b;
        }
    
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
    
        public static string Add (int a, int b, bool c)
        {
            int sum = a + b;
            if (c == true)
            {
                if (sum > 1)
                    return $"{sum} dollars";
                else if (sum == 1)
                    return $"{sum} dollar";
                else
                    return "Huh!?";
            }
            else
                return $"sum";
        
        
        }
    
    
    }
   

}
