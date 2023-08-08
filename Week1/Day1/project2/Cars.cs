namespace ProjectDua;

public class Car 

{
	public Engine engine;
	public Lamp lamp;
	public Tire tire;
	
	public void EngineStart()
	
	{
		engine.EngineRun();
	}
	
	public void LampCheck()
	
	{
		lamp.TurnOn();
	}
}