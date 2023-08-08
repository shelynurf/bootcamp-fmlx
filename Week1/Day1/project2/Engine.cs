namespace ProjectDua;

public class Engine

{
	public string engineType;
	
	public Engine(string engineType)
	
	{
		this.engineType = engineType;
	}
	public void EngineRun()
	
	{
		Console.WriteLine("Running " + engineType);
	}
} 
