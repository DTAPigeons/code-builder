using System;

namespace CodeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var classBuilder = new CodeBuilder()
                                                .AddClass("Person")
                                                .AddField("Name", "string")
                                                .AddField("Age", "int")
                                                .AddClass("Company")
                                                .AddField("Name", "string")
                                                .AddField("Owner", "Person");
            
            Console.WriteLine(classBuilder);
            Console.ReadLine();
        }
    }
}
