namespace ProjectDua;

public class Tire

{
	public int tireSize;
	
	public Tire(int tireSize)
	
	{
		this.tireSize = tireSize;
	}
	public void CheckTire() 
	
	{
		Console.WriteLine("Tire Size " + tireSize);
	}
}