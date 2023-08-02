namespace encapsulation;

public class Family
{
	public string? name;
	private int _age;
	private int _nik;
	
	public Family(string name, int age, int nik)	
	{
		this.name = name;
		_age = age;
		_nik = nik;
	}
	
	public void Eat()
	
	{
		Console.WriteLine(name + " is eating");
	}
	
	
	public virtual void isMarried()
	
	{
		Console.WriteLine(name + " is Married");
	}
}

