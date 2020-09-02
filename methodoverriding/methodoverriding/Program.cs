using System;
public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("eating");
    }
}
public class dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("bread eating");

    }
}
public class Test
{
    public static void Main()
    {
        dog d = new dog();
        d.eat();

    }
}