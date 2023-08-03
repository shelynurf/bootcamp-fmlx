public interface IHuman

{
	void Role();
}

public class Mom : IHuman

{
	public void Role()
	
	{
		Console.WriteLine("Managing house");
	}
}

public class Dad : IHuman

{
	public void Role()
	
	{
		Console.WriteLine("Looking for money");
	}
}

public class Children : IHuman

{
	public void Role()
	
	{
		Console.WriteLine("Study at school");
	}
}

public class Family

{
	public IHuman human;
	
	public Family(IHuman human)
	
	{
		this.human = human;
	}
	
	public void RoleFamily()
	
	{
		human.Role();
	}
}


class Program

{
	static void Main()
	
	{
		Mom mom = new Mom();
		Dad dad	= new Dad();
		Children children = new Children();
		
		mom.Role();
		dad.Role();
		children.Role();
		
		
		
	}
}
