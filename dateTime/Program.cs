class Program

{
	static void Main()
	
	{
		DateTime birthday = new DateTime(1997, 3, 26);
		DateTime today = new DateTime();
		TimeSpan age = today - birthday;
		
		
		Console.WriteLine(age);
		
	}
}