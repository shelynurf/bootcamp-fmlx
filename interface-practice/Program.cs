public interface IHuman

{
	void Role();
}

public class Mom : IHuman

{
	public void Role()
	
	{
		Console.WriteLine("managing house");
	}
}

public class Dad : IHuman

{
	public void Role()
	
	{
		Console.WriteLine("looking for money");
	}
}

public class Children : IHuman

{
	public void Role()
	
	{
		Console.WriteLine("study at school");
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
