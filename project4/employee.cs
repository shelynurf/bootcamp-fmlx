namespace project4;

public class Employee
{
	public string _name;
	private int _salary;
	private int _nik;
	
	public Employee(string name, int salary, int nik)
	
	{
		_name = name;
		_salary = salary;
		_nik = nik;	
	}
	
	public int GetSalary()
	
	{
		return _salary;
	}
	
	public int SetSalary(int salary)
	
	{
		_salary = salary;
		return _salary;
	}
	
	
	
}
