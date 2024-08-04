using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Class3
    { 
        static void Main(string[] args)
        {
            try
            {
                int i = 1;
                int j = 0;
                int k = i / j;
               
            }
            finally
            {
                Console.WriteLine("try without catch block");

            }

        }

    }
}
/*
  can we have only try block without catch block in real application ?

YES -  we can have only try block without catch block , but then we must have finnally block with try block.  
 * 
 */
