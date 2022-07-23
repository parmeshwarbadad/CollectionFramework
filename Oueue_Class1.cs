using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionFramework
{

    class Employee
    {
        int eid;
        string ename;
        int salary;

        public Employee(int id, string name, int salary)
        {
            this.eid = id;
            this.ename = name;
            this.salary = salary;
        }



        static void Main(string[] args)
        {
            Queue<Employee> lst = new Queue<Employee>();

            lst.Enqueue(new Employee(101, "Param", 22000));
            lst.Enqueue(new Employee(102, "Anuj", 23000));
            lst.Enqueue(new Employee(103, "Pralhad", 32000));
            lst.Enqueue(new Employee(104, "Rahul", 43000));
            lst.Enqueue(new Employee(105, "Prerna", 32000));
            lst.Enqueue(new Employee(106, "Pratiksha", 23000));



            foreach (Employee i in lst)
            {
                Console.WriteLine($" Employee Id : {i.eid} Employee Name : {i.ename} salary : {i.salary}");
            }






        }
    }

}
