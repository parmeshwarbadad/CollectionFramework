using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionFramework
{
    class Employee1
    {

        int id;
        string name;
        int salary;
        public Employee1(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }



        static void Main(string[] args)
        {

            Stack<Employee> sl = new Stack<Employee>();

            sl.Push(new Employee(101, "Anuj", 78600));
            sl.Push(new Employee(102, "Param", 89600));
            sl.Push(new Employee(103, "Pralhad", 45600));
            sl.Push(new Employee(107, "Vishnu", 78600));
            sl.Push(new Employee(108, "Ram", 25400));
            sl.Push(new Employee(109, "Narayna", 11600));
            sl.Push(new Employee(110, "Arjun", 22600));



            foreach (Employee aa in sl)
            {
                Console.WriteLine($"employee id : {aa.id} employee name: {aa.name} employee salary :{salary}");
            }


        }

    }
}




