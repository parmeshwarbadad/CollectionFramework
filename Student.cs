using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionFramework
{
    class Student : IComparable<Student>
    {
        string name;
        int percent;
        string qualification;

        public Student(string name, int percent, string qualification)
        {
            this.Name = name;
            this.Percent = percent;
            this.Qualification = qualification;
        }
        public override string ToString()
        {
            return "name= " + name + "Percentage= " + percent + "Education= " + qualification;
        }

        public int CompareTo(Student other)
        {

            return this.name.CompareTo(other.name);
        }


        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public string Qualification { get => qualification; set => qualification = value; }

    }   
    class B
    { 
        static void Main(string[] args)
        {
            List<Student> lst =new List<Student>();
            lst.Add(new Student("Pralhad", 99, "BE"));
            lst.Add(new Student("Anuj", 89, "BSC"));
            lst.Add(new Student("Kiran", 97, "MCA"));
            lst.Add(new Student("Param", 98, "BTech"));
            lst.Add(new Student("Amol", 96, "Law"));

            lst.Sort();

            lst.ForEach(s1 => Console.WriteLine(s1));

           List<Student> ss= lst.FindAll(obj => obj.Percent > 90);


            foreach(Student s in lst)
            {
                if(s.Percent >90)
                {
                    Console.WriteLine(s);
                }
            }

            
        }
    }
}
