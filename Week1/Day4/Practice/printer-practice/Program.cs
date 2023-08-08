public interface IPrint {
	void Print();
}
public interface IFax {
	void Fax();
}
public interface IScan {
	void Scan();
}

public interface IprinterMahal : IPrint, IScan, IFax

{
	
}

public class Printer300Ribu : IPrint {
	public void Print() {
		Console.WriteLine("Printing Murah");
	}
}
public class Printer700Ribu : IPrint, IScan {
	public void Print() {
		Console.WriteLine("Printing");
	}
	public void Scan() {
		Console.WriteLine("Scanning");
	}
}
public class Printer3Juta : IprinterMahal 
{
	public void Print() {
		Console.WriteLine("Printing High Quality");
	}
	public void Scan() {
		Console.WriteLine("Scanning");
	}
	public void Fax() {
		Console.WriteLine("Faxing");
	}
}

public class Program {
	static void Main() {
		Printer3Juta print3 = new();
		// var print4 = new Printer3Juta();
		Printer700Ribu print2 = new();
		Printer300Ribu print1 = new();
		
		IPrint printerMurah = print1;
		printerMurah.Print();
		
		IprinterMahal printerMahal = print3;
		printerMahal.Print();
		printerMahal.Scan();
		printerMahal.Fax();
		
		IScan printerScan = print3;
		// printerScan.Print();
		printerScan.Scan();
		// printerScan.Fax();
		
		IPrint printer = print3;
		printer.Print();
		// printer.Scan();
		// printer.Fax();
		
		IFax printerFax = print3;
		// printerFax.Print();
		// printerFax.Scan();
		printerFax.Fax();
		
		
		}

}