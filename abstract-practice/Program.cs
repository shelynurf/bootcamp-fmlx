public abstract class Family

{
	public string name;
	protected int _age;
	private int _nik;
	
	public Family(string name, int age, int nik)
	
	{
		this.name = name;
		_age = age;
		_nik = nik;
	}
	public virtual void isMarried()
	
	{
		Console.WriteLine(name + " is married");
	}
	
	public abstract void Role();
}

public class Mom : Family

{
	public Mom(string name, int age, int nik) : base(name, age, nik)
	
	{
		
	}
	public override void Role()
	{
		Console.WriteLine(name + " Managing house");
	}
}

public class Dad : Family

{
	public Dad(string name, int age, int nik) : base(name, age, nik)
	
	{
		
	}
	public override void Role()
	{
		Console.WriteLine(name + " Looking for money");
	}
}

public class Children : Family

{
	public Children(string name, int age, int nik) : base(name, age, nik)
	{}
	public override void Role()
	{
		Console.WriteLine(name + " Study at school");
	}

	public override void isMarried()
	{
		Console.WriteLine(name + " is not married");
	}
	
	public void Criteria()
	
	{
		if (_age < 25 )
		
		{
			Console.WriteLine(name + " is Teenager");
			
		}
		else
		
		{
			Console.WriteLine("Adult");
		}
	}
	
}

class Program

{
	static void Main()
	
	{
		Mom mom = new Mom("mom", 45, 12345);
		Dad dad = new Dad("dad", 50, 23456);
		Children children = new Children("children", 18, 34567);
		
		
		
		mom.isMarried();
		children.Criteria();
		dad.Role();
		
		
		
	}
}