using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.Encodings;
using System.Text;

namespace Nasa231012
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Keres> keresek = new();
            using StreamReader sr = new(
                path: @"..\..\..\src\NASAlog.txt",
                encoding: System.Text.Encoding.UTF8);
            while (!sr.EndOfStream) keresek.Add(new(sr.ReadLine()));
            Console.WriteLine($"{keresek.Count}") ;

            Console.ReadLine();
        }
    }
}
