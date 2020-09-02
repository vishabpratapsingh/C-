using System;
using System.Threading.Tasks;
using System.Net.Http;
namespace CSharpFeatures
{
    class AsynchronousMethod
    {
        static void Main(string[] args)
        {
            Task<int> result = add();
            Console.WriteLine("length: {0}", result.Result);
        }  
        async static Task<int> add()
        {
            Task<string> TaskUrl = new HttpClient().GetStringAsync("http://www.javatpoint.com");
            string result = await TaskUrl;
            return result.Length;
        }
    }
}