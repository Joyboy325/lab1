using System;

public class Student
{
	private int id;
	private String name;
	private String surname;
    public Student(int id,string name,string surname)
    {
		this.id = id;
		this.name = name;
		this.surname = surname;
    }
	public void getName()
    {
		Console.WriteLine(this.name);
    }
}
