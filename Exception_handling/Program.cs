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
