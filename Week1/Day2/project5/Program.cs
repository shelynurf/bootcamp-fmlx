class Program

{
	static void Main()

	{
		Animal animal = new Animal();
		Cat cat = new Cat();
		Dog dog = new Dog();
		Ant ant= new Ant();
		
		animal.MakeSound();
		cat.MakeSound();
		dog.MakeSound();
		ant.MakeSound();
		
		animal.Eat();
		animal.Eat("fruit");
		animal.Eat("fruit", 5);
		
		
	}
}

class Animal

{
	public virtual void MakeSound() // overloading, parent

	{
		Console.WriteLine("Sounding");
		
	}
	
	
	// overriding
	public void Eat()
	
	{
		Console.WriteLine("Eat default");
	}
	
	public void Eat(string food)
	
	{
		Console.WriteLine("Eat " + food);
	}
	
	public void Eat(string food, int x)
	
	{
		Console.WriteLine($"Eat {food} for {x} time");
	}

}

class Cat : Animal
{
	public override void MakeSound()

	{
		Console.WriteLine("Meow");
		}
}

class Dog : Animal

{
	public override void MakeSound()
	{
		Console.WriteLine("Bark");

	}

}

class Bird : Animal

{
	public override void MakeSound()
	{
		Console.WriteLine("Chip");
	}
	
}

class Ant : Animal

{
	
}