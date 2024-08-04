namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                int j = 0;

                int k = i / j;

            }
            catch (Exception ex){
            
            Console.WriteLine(ex.Message);
            
            }
            finally
            {
                Console.WriteLine("finally");
            }

        }
    }
}
/* 
 How to implement Exception Handling in C#?
Exception handling in Object- Oriented Programming is used to Manage Errors.

1. try - a try block is a block of code inside which any error can occur . 

2. catch - when any error occur in try block then it is passed to catch block to handle it . 

3 . finally - the finally block is used to execute a given set of statements , whether an exception occur or not . 

 */