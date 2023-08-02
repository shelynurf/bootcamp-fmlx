using System.Runtime.InteropServices;
using inheritance;

class Program

{
	static void Main(string[] args)
	
	{
		Family amel = new Family("amel", 27, 678976);
		Dad andre = new Dad("andre", 45, 12345, "ceo");
		Mom lucy = new Mom("lucy", 40, 23456);
		Child dinda = new Child("dinda", 15, 34567);
		Console.WriteLine("child name \t : " + andre.name);
		Console.WriteLine("dad age \t : " + andre.GetAge());
		Console.WriteLine("mom role \t : " + lucy.Role());
		dinda.isMarried();
		andre.isMarried();
		amel.Holiday();
		amel.Holiday("Bali");
		amel.Holiday("Bali", 3);
	
		
		
	}
}