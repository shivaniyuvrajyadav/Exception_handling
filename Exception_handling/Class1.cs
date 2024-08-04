using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Class1
    {  
        static void Main(string[] args)
        {
            try
            {
                int i = 10;
                int j = 0;
                int k = i / j;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            { 
                Console.WriteLine("Exception");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

/*
 can we execute multiple catch blocks?

  NO 

we can write multiple catch blocks but when we will run the application and if 
any error occur , only one out of them will execute based on the type of the error. 
 */