//Static
static class Calculator {
	public static int Add(int a, int b) {
		return a+b;
	}
	public static int Multiply(int a, int b) {
		return a * b;
	}
	public static int Divider(int a, int b) {
		return a / b;
	}
	 static  public int Substract(int a, int b) {
		return a - b;
	}
}
class Program {
	static void Main() {
		int x = 3;
		int y = 5;
		Console.WriteLine(Calculator.Add(x,y)); // 8
		Console.WriteLine(Calculator.Multiply(x,y)); //15
		// Calculator calc = new();
		// calc.Add(x,y); Error, must call it with the class Name
	}
}