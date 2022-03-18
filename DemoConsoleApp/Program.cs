using System;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add(5, 7);
            Subtract(10, 6);
            Employee obj = new Employee();
            obj.Name = "Monisha";
            
            obj.Id = 50;
            Console.WriteLine("Hello I am " + obj.Name + "and my Id is " + obj.Id);

            obj.Display("Monisha", 01);

            Employee obj2 = new Employee("kosdh", 43);
            Console.WriteLine("Hello I am " + obj2.Name + "and my Id is " + obj2.Id);


        }
       static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The sum is " + c);
        }
        static void Subtract (int c, int d)
        {
            int sub = c - d;
            Console.WriteLine("The Subraction is " + sub);
        }


    }
}
