using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
}
public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string AcadmicYear { get; set; }
    public List<Course> Courses { get; set; }
}

public class StudentsDatabase : List<Student>
{
    public StudentsDatabase()
    {
        Add(new Student()
        {
            StudentId = 1,
            StudentName = "MS Dhoni",
            AcadmicYear = "First",
            Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
        });

        Add(new Student()
        {
            StudentId = 2,
            StudentName = "Shridhar",
            AcadmicYear = "Second",
            Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=104,CourseName="MVC" },
                 new Course() {CourseId=105,CourseName="AngularJS" }
            }
        });
        Add(new Student()
        {
            StudentId = 3,
            StudentName = "Tarun",
            AcadmicYear = "Third",
            Courses = new List<Course>()
            {
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=104,CourseName="MVC" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
        });
        Add(new Student()
        {
            StudentId = 4,
            StudentName = "Vishab",
            AcadmicYear = "First",
            Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
        });

        Add(new Student()
        {
            StudentId = 5,
            StudentName = "Gaurav",
            AcadmicYear = "Second",
            Courses = new List<Course>()
            {
                 new Course() {CourseId=104,CourseName="MVC" },
                 new Course() {CourseId=105,CourseName="AngularJS" },
                 new Course() {CourseId=106,CourseName="KnockoutJS" }
            }
        });
        Add(new Student()
        {
            StudentId = 6,
            StudentName = "Rishab",
            AcadmicYear = "Third",
            Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
        });
    }
}

public class Employee
{
    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public string DeptName { get; set; }
}

public class EmployeesDatabase : List<Employee>
{
    public EmployeesDatabase()
    {
        Add(new Employee() { EmpNo = 1, EmpName = "Arun", DeptName = "IT" });
        Add(new Employee() { EmpNo = 1, EmpName = "sandy", DeptName = "Systems" });
        Add(new Employee() { EmpNo = 1, EmpName = "Chandni", DeptName = "IT" });
        Add(new Employee() { EmpNo = 1, EmpName = "Dhawan", DeptName = "Systems" });
        Add(new Employee() { EmpNo = 1, EmpName = "Elite", DeptName = "IT" });
        Add(new Employee() { EmpNo = 1, EmpName = "Feroj", DeptName = "Systems" });
    }
}

    public class A
{


public static void Main(string[] args)
{
    //1. Get the Data in JSON Serialized Form
    string StudentsData = JsonConvert.SerializeObject(new StudentsDatabase(), Formatting.Indented);
    //Console.WriteLine(StudentsData);  

    //2. Convert the JSON string into an Array
    JArray studentsArray = JArray.Parse(StudentsData);


    //3. Read all Student Names

    var resStudents = (from s in studentsArray
                       select s["StudentName"]).ToList();

    Console.WriteLine("Only Student Names");
    foreach (var item in resStudents)
    {
        Console.WriteLine(item.Value<string>().ToString());
    }

    //4. Get only Course Details 
    Console.WriteLine();
    var result = (from s in studentsArray.Children()["Courses"]
                  select s).ToList();

    Console.WriteLine("Course Details");
    foreach (var item in result.Children().ToList())
    {
        Console.WriteLine(item.ToObject<Course>().CourseId + "\t" + item.ToObject<Course>().CourseName);
    }


    //5. Get the Data in JSON Serialized Form
    string employeesData = JsonConvert.SerializeObject(new EmployeesDatabase(), Formatting.Indented);

    //6. Convert the JSON string into an Array
    JArray employeesArray = JArray.Parse(employeesData);

    //7.
    var empGroupByDeptName = from e in employeesArray
                             group e by e["DeptName"] into deptGroup
                             select new
                             {
                                 DeptName = deptGroup.Key,
                                 EmpCount = deptGroup.Count()

                             };

    Console.WriteLine("Deptrtment \t\t Total Employees Employee");
    foreach (dynamic deptGrp in empGroupByDeptName)
    {
        Console.WriteLine(deptGrp.DeptName + " \t\t " + deptGrp.EmpCount);
    }

    Console.ReadLine();
}
}

