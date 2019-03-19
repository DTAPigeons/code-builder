using System;

namespace CodeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var classBuilder = new ClassBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(classBuilder);
            Console.ReadLine();
        }
    }
}
