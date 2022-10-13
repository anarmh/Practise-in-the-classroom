using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public bool isMarried;
        public int number;
        public Employee():this(12)
        {
            Console.WriteLine("Hello p414");
        }
        public Employee(string empname,string empsurname,int empage)
        {
            string name = empname;
            string surname = empsurname;
            int age = empage;
            Console.WriteLine(empname+" "+empsurname+" "+empage);
        }
        public Employee(string empAddress)
        {
            string address = empAddress;
            Console.WriteLine(address);
        }
        
        public Employee(bool married):this("Sumqayit")
        {
            bool isMarried = married;
            Console.WriteLine(isMarried);

        }
        public Employee(int empnumber)
        {
            int number = empnumber;
            Console.WriteLine(number);
        }
    }
}
