using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Record_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRecord std1 = new StudentRecord()
            {
                Name = "Mahir",
                Surname = "Musayev",
                Age = 20,
                Group = "AB106"
            };
            StudentRecord std2 = std1 with { Name = "aaaa" };
            Console.WriteLine(std1);
                Console.WriteLine(std2); 
        }

        record StudentRecord(string Name = "XX", string Surname = "YY", int Age = 0, string Group = "");
        internal class StudentClass
        {
            public string Name { get; init; }
            public string Surname { get; init; } = "XXX";

        }
    }
}
