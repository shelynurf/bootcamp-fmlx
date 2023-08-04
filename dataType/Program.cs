class Program

{
	static void Main()
	
	{
		int a = 1;
		int b = 2;
		Console.WriteLine((a+b) == 3);
		
		float c = 0.1f;
		float d = 0.2f;
		Console.WriteLine((c+d) == 0.3f);
		
		double e = 0.1;
		double f = 0.2;
		Console.WriteLine((e+f) == 0.3); // false
		
		decimal g = 0.1M;
		decimal h = 0.2M;
		Console.WriteLine((g+h) == 0.3M);
	}
}