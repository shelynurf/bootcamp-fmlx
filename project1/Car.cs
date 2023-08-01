namespace CarLibrary;
class Car

{
	public string brand;
	public int door;
	public Engine[] engine;
	
	public Tire tire;
}

class Engine

{
	public string engineType;
	public void engineRun()
	
	{
		Console.WriteLine("Engine Run");
	}
}

class Tire

{
	public int tireSize;
	public void tirePump()
	
	{
		Console.WriteLine("Tire Pump");
	}
	
}