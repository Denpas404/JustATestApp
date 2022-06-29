using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustATestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "infobase.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

            string txt = File.ReadAllText(path);

            Console.WriteLine(txt);

            Console.ReadKey();
        }
    }
}
