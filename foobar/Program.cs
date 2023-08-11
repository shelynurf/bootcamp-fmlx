using FoobarLibrary;

public class Program

{
	static void Main()
	
	{	Console.Write("Input your number : ");
		int input = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(Foobar.GetFoobar(input));
		
		
	}
}