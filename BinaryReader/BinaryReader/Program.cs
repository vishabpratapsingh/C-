using System;
using System.IO;
namespace BinaryWriterExample
{
    class Program
    {
     public   static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {
            using ( BinaryWriter a = new BinaryWriter(File.Open("e:\\binaryfile.dat", FileMode.Create)))
            {

                a.Write(12.5);
                a.Write("this is string data");
               a.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("e:\\binaryfile.dat", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
    }
}