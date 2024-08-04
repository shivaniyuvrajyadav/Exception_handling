using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Exception_handling
{
    internal class Class2
    { 
        static void Main(string[] args)
        {
            string connectionstring = "hey";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring)) ;

                con.Open();

                con.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
        }
    }
}

/*
     When to use Finally in real application ?

      finally block  is mostly used to dispose the unwanted objects when they 
      are no more required. this is good for performance , otherwise you have to wait 
      for garbage collector to dispose them. 
 */