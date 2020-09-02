using System;
using System.IO;
namespace CSharpProgram
{
   public  class FileInfoProgram
    {
       public  static void Main(string[] args)
        {
            try
            {
                // Specifying file location  
                string loc = "d:\\abc.txt";
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(loc);
                //creating a file instance to write
                StreamWriter sw = file.CreateText();
                //writing to the  file
                sw.WriteLine("hello vishab pratap singh");
                sw.Close();
                // Opening file to read  
                StreamReader sr = file.OpenText();
                string data = "";
                while ((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }
    }
}