class Car {
	//Variable
	public int x;
	public string? y;
	public IEngine? engine;
	
	//Property or Variable Method 
	public int z { get; private set; }
	public string q { 
	get
	{
		return q + "World";
	}
	set
	{ 
		q = value + "Hello";
	} 
	}
	
	//Method
	public void Run() { }
	public int Stop() { return 0; }
	public int Stop(int x) { return x; }
}

public interface IEngine {
	public int x {get; set;}

	void Run();
	void Start();
}