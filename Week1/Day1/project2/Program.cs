using ProjectDua;

class Program

{
	static void Main()
	
	{
		Engine combustionEngine = new Engine("combustionEngine");
		Engine electricEngine = new Engine("electricEngine");
		Engine dieselEngine = new Engine("electricEngine");
		Engine kayuhEngine	 = new Engine("electricEngine");
		
		Lamp philips = new Lamp("philips");
		Lamp petromak = new Lamp("petromak");
		Lamp sanyo = new Lamp("sanyo");
		
		Tire woodenTire = new Tire(11);
		Tire rubberTire = new Tire(12);
		Tire offRoadTire = new Tire(13);
				
		Car teslaCar = new Car();
		teslaCar.engine = combustionEngine;
		teslaCar.lamp = philips;
		teslaCar.tire = woodenTire;
		Car toyotaCar = new Car();
		toyotaCar.engine = dieselEngine;
		toyotaCar.lamp = petromak;
		toyotaCar.tire = woodenTire;
		
		teslaCar.EngineStart();
		toyotaCar.LampCheck();
		
		
	}
}
