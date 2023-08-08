using CatLibrary; // to import namespace
using CarLibrary;
class Program

{
	static void Main()
	
	{
		Console.WriteLine("Hello World2");
		Cat alex = new Cat();
		alex.name = "alex";
		alex.age = 2;
		alex.Eat("fish");
		string name = alex.name;
		Console.WriteLine(name);
		
		Cat pedro = new Cat();
		pedro.name = "pedro";
		pedro.age = 5;
		pedro.MakeSound();
		
		Calculator calculator = new Calculator();
		int hasil = calculator.Add(3, 5);
		Console.WriteLine(hasil);
		
		Car car = new Car();
		car.brand = "Toyota";
		car.door = 4;
		
		
		Engine electric = new Engine();
		Engine electric2 = new Engine();
		Engine[] electrics = {electric, electric2};			
		Tire inchTire = new Tire();
		car.engine = electrics;
		car.tire = inchTire;
		// car.engine.engineRun();
		car.tire.tirePump();
		// electrics.engineType = "engine1";
		// electric.engineType = "engine1";
		// electric2.engineType= "engine2";
		Console.WriteLine(electrics);
	}
}