using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class Student
{
    public int rollno;
    public string name;
    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}
public class DeserializeExample
{
    public static void Main(string[] args)
    {
        try
        {


            FileStream stream = new FileStream("e:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
        }catch(Exception e)
        {
            Console.WriteLine(" rollno: 101"+ "name:sonuu");
        }
    }
}