using CatLibrary; // to import namespace
class Program

{
	static void Main()
	
	{
		Console.WriteLine("Hello World2");
		Cat alex = new Cat();
		alex.name = "alex";
		alex.age = 2;
		alex.Eat();
		string name = alex.name;
		Console.WriteLine(name);
		
		Cat pedro = new Cat();
		pedro.name = "pedro";
		pedro.age = 5;
		pedro.MakeSound();
		
	}
}