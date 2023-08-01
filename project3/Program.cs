using AnimalLibrary;

class Program

{
	static void Main()

	{
		Cat alex = new Cat();
		alex.name = "alex";
		Console.WriteLine(alex.name);
		alex.Eat();

	}
}