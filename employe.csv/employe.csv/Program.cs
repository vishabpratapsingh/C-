using System;
using System.IO;

namespace CompanyDetails
{
    public enum Department { HR, DEV, TESTING, QA, MANAGEMENT }
    class CompanyDetails
    {
        private static Random random = new Random();
        private static int employeeId = 100;
        public enum Department { HR, DEV, TESTING, QA, MANAGEMENT }
        public static void Main(string[] args)
        {

            string[] employeeName = { "SHAFI", "ROHIT", "RISHAB", "VISHAB", "SANDY" };
            string[] companyName = { "ORACLE", "GOOGLE", "AMAZON", "BIZRUNTIME", "DXC" };
            string[] department = Enum.GetNames(typeof(Department));
            Console.WriteLine("number of company" + companyName.Length);
            addRecord("EmployeeId","EmployeeName","Department","CompanyName","CompanyID", "C:\\Users\\Vishab\\Desktop\\task2\\employe.csv");

            for (int j = 0; j < companyName.Length; j++)
            {
                int numberofPerson = 0;
                Console.WriteLine("company name =" + companyName[j]);
               
           
                for (int i = 0; i < 200; i++)
                {
                    numberofPerson ++;
                    string companyID = companyName[j] + 100;
                    employeeId += i;
                    string id = Convert.ToString(employeeId);
                    addRecord(id, employeeName[random.Next(0, 5)], department[random.Next(0, 5)], companyName[j], companyID, "C:\\Users\\Vishab\\Desktop\\task2\\employe.csv");
                }
            }
        }

        public static void addRecord(string employeeId, string employeeName, string Department, String companyName, string companyId, string filepath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(filepath, true))
                {
                    file.WriteLine(employeeId + "," + employeeName + "," + Department + "," + companyName + "," + companyId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
