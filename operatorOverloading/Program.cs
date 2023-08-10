public class Family
{
	public string name;
	
	public Family(string name)
	{
		this.name = name;
	}
	
	public static Family operator + (Family family1, Family family2)
	{
		return new Family(family1.name + family2.name);
	}
}

class Program
{
	static void Main()
	{
		Family family1 = new Family("Agus");
		Family family2 = new Family("Bella");
		Family family3 = family1 + family2;
		Console.WriteLine(family3.name);
	}
}
