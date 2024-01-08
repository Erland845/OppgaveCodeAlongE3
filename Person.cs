using System;

public class Person
{
	public string Name { get; set; }
	public int Age { get; set; }
	public string Address { get; set; }
	public Person(string name, int age, string address) 
	{
		Name = name;
		Age = age;
		Address = address;
	}
	public void PrintPerson() 
	{
		Console.WriteLine($"Name: {Name}, Age: {Age}, Adress: {Address}");
	}
	

}
