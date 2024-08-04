using System;

public class Class1
{
	public Class1()
	{ 
		static void Main(string[] args)
		{
			try
			{
				int i = 0;
				int j = 0;

				int k = i / j;
			}
			catch (ArithmaticException ex)
			{
				Console.WriteLine("Alert");
				Console.WriteLine(ex.Message);
			}
			catch(ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.Message);
			}
		}
	}
}
