using System;

public class Employee
{
    public int id;
    public string name;
    public float salary;
    public void insert(int i, string n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
public class Testinformation
{
    public static void Main()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
        e1.insert(101, "vishab", 123456);
        e2.insert(102, "rishab", 123908);
        e1.display();
        e2.display();

    }
}



