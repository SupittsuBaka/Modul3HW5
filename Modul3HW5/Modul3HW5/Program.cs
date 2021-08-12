using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW5
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var str = await Concatination();
            Console.WriteLine(str);
        }

        public static async Task<string> ReadHello()
        {
            return await File.ReadAllTextAsync(@".\Hello.txt");
        }

        public static async Task<string> ReadWorld()
        {
            return await File.ReadAllTextAsync(@".\World.txt");
        }

        public static async Task<string> Concatination()
        {
            var words = new List<Task<string>>();
            words.Add(ReadHello());
            words.Add(ReadWorld());
            return string.Join(' ', await Task.WhenAll(words));
        }
    }
}
