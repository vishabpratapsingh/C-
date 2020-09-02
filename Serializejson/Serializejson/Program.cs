using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsManager { get; set; }
    public DateTime JoinedDate { get; set; }
    public IList<string> Titles { get; set; }
}

public class Program
{
    public static void Main()
    {
        Employee employee = new Employee
        {
            FirstName = "Shiva",
            LastName = "Kumar",
            IsManager = true,
            JoinedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
            Titles = new List<string>
            {
                "Sr. Software Engineer",
                "Applications Architect"
            }
        };

        string json = JsonConvert.SerializeObject(employee, Formatting.Indented);


        Console.WriteLine(json);

    }
}