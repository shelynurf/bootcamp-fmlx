namespace FoobarLibrary;

public class Foobar
{
	public static string GetFoobar(int x)
	
	{
		for(int i = 0; i <= x; i++)
		
		{
			
			if (i > 0 && i % 3 == 0)
			
			{
				if (i % 3 == 0 && i % 5 == 0)
				
				{
					return "foobar";
				}
				else 
				
				{
					return "foo";
				}
			}
			else if (i > 0 && i % 5 == 0)	
			
			{
				return "bar";
			}
			else
			
			{
				return i.ToString();
			}
		}
	}
}