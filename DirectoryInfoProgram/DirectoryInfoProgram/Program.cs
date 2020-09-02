using System;
using System.IO;
namespace CSharpProgram
{
   public class DirectoryInfoProgram
    {
       public static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\fileprogram");
            try
            {
                directory.Create();
                Console.WriteLine("the directory is created");
                directory.Delete();
                Console.WriteLine("The directory is deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }
        }
    }
}