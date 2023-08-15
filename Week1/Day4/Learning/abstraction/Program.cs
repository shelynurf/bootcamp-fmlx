public interface IPrint {
	void Print();
}
public interface IFax {
	void Fax();
}
public interface IScan {
	void Scan();
}
public abstract class ParentAbstract {
	public int x;
	public int y;
	
	public int Add() { //non abstract
		return x+y;
	}
	public abstract int GetTotal();
}

public class Child : ParentAbstract {
	public override int GetTotal() {
		return x+y;
	}
	public void Scan() {
		Console.WriteLine("Scan");
	}
}

class Program

{
	static void Main() {
	Child child = new Child();
	ParentAbstract parent = child;
	
	child.x = 4;
	child.y = 3;
	parent.x = 5;
	parent.y = 6;
	Console.WriteLine("parent : " + parent.Add());
	Console.WriteLine("parent : " + parent.GetTotal());
	Console.WriteLine("child : " + child.Add());
	Console.WriteLine("child : " + child.GetTotal());

}
}