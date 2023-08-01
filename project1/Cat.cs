namespace CatLibrary;
public class Cat

{
	//variable
	public bool isSmoothFur; // camel case
	public string? name;
	public bool isMale;
	public int age;
	public bool isOwned;
	public string? color;
	
	// method
	public void MakeSound() // pascal case
	
	{
		Console.WriteLine(name + " Make Sound");
	}
	
	public void Scratch()
	
	{
		Console.WriteLine(name + " Scratch");
	}
	
	public void Sleep()
	
	{
		Console.WriteLine(name + " Sleep");
	}
	
	public void Eat( string food)
	
	{
		Console.WriteLine(name + " eat " + food);
	}
}