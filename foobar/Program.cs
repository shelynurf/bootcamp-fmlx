public class Program

{
	static void Foobar(int x)
	
	{
		for(int i = 0; i <= x; i++)
		
		{
			
			if (i > 0 && i % 3 == 0)
			
			{
				if (i % 3 == 0 && i % 5 == 0)
				
				{
					Console.WriteLine("foobar");
				}
				else 
				
				{
					Console.WriteLine("foo");
				}
			}
			else if (i > 0 && i % 5 == 0)	
			
			{
				Console.WriteLine("bar");
			}
			else
			
			{
				Console.WriteLine(i);
			}
		}
	}
	static void Main()
	
	{	Console.Write("Input your number : ");
		int input = Convert.ToInt32(Console.ReadLine());
		Foobar(input);
		
	}
}