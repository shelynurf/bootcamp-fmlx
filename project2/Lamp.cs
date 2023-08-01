namespace ProjectDua;

public class Lamp

{
	public string lampType;
	
	public Lamp(string lampType)
	
	{
		this.lampType = lampType;
	}
	public void TurnOn()
	
	{
		Console.WriteLine("Turning " + lampType);
	}
}