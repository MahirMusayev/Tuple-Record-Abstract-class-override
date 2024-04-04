namespace Tuple_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name , string Surname ,int Age) result = A(); // 1 ci usul
            Console.WriteLine(result);


            var result1 = B(); // 2ci usul
            Console.WriteLine(result1.Item1);
        }
        static (string, string,int) A()
        {
            return ("mahir","musayev" ,20);

        }


        static (string, int) B()
        {
            return ("mahir", 20);
        }
    }
}
