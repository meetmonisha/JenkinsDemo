using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    public class Employee
    {

        public Employee()
        {

        }
        public Employee(string name,int id)
        {
            this.name = name;
            this.id = id;
        }
        private string name;
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }
        }

        private int id;
        public int Id
        {
            get
            {
                return id;

            }
            set
            {
                id = value;
            }
        }

        public void Display(string name, int id)
        {
            Console.WriteLine("Name: " + name + "Id: "+id);
        }
    }
}
