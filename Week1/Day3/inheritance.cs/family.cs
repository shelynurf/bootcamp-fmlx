namespace inheritance;

public class Family
{
	public string? name;
	private int _age;  // ENCAPSULATION
	private int _nik; // ENCAPSULATION
	
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
	
	public int GetAge()
	
	{
		return _age;
	}
	
	
	// OVERRIDING
	public virtual string Role()
	
	{
		return name + " is looking for money";
	}
	
	// OVERLOADING
	public void Holiday()
	
	{
		Console.WriteLine(name + " is on vacation");
	}
	
	public void Holiday(string destination)
	
	{
		Console.WriteLine($"{name} is on vacation to {destination}");
	}
	
	public void Holiday(string destination, int duration)
	
	{
		Console.WriteLine($"{name} is on vacation to {destination} for {duration} days");
	}
}


public class Mom : Family // INHERITANCE

{
	
	public Mom (string name, int age, int nik) : base(name, age, nik)
	
	{
		
	}
	
	public string  Role()
	
	{
		return name + " managing house";
	}
}
	

public class Dad : Family

{
	public string job;
	public Dad (string name, int age, int nik, string job) : base(name, age, nik)
	
	{
		this.job = job;
	}
	
	
	
	
}

public class Child : Family

{
	public Child (string name, int age, int nik) : base(name, age, nik)
	
	{
		
	}
	public override void isMarried()
	
	{
		Console.WriteLine(name + " is not Married");
	}
	
	public string Role()
	
	{
		return name + " study at school";
	}
}
