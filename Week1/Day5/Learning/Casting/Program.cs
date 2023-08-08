class Program

{
	public static void Boxing()

	{
		int a = 9;
		object obj = a; // boxing, memasukkan int ke object. object bisa menerima type data apapun
		int b = (int)obj; // unboxing, obj harus dicasting ke integer, karena integer tidak bisa menerima 
		Console.WriteLine(b);
	}

	static void Dinamic()

	{
		//dynamic 
		//Remove the type safety 
		//Dont use it because its inefficient
		int a = 9;
		dynamic b = a;
		Console.WriteLine(b); //9

		b = "Hello";
		Console.WriteLine(b); // "Hello"
	}
	
	static void ExplisitCasting()
	
	{
		double a = 9.2;
	int b = (int)a;
	
	Console.WriteLine(b);
	}
	static void Main()

	{
		Boxing();
		Dinamic();
		ExplisitCasting();
		
		
	}
}