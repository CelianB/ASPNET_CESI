using System;

namespace TP1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Contact(new DateTime(1996,08,28));
            Console.WriteLine(user.Age);
            Console.ReadKey();
        }
    }
}