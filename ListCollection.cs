using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionFramework
{
    class ListCollection
    {
        static void Main(string[] args)
        {
           List<string> lst2 = new List<string>() { "deepa", "Kirti", "Medha" };



            List<string> lst = new List<string>(20);

            lst.Add("A");
            lst.Add("B");
            lst.Add("C");
            lst.Add("B");
            lst.Add("D");
            lst.Add("A");

            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
            lst.AddRange(lst2);
            //lst.InsertRange(0, lst2);

            // lst.Remove("A");
            //lst.RemoveAt(2);
            lst.Add("chitar");
            lst.Insert(3, "chitra");


            string[] str = lst.ToArray();
            //lst.Clear();
            int idx1 = lst.IndexOf("B");
            int idx2 = lst.LastIndexOf("A");
            Console.WriteLine(lst.Contains("A"));
            Console.WriteLine("Last index if A: " + idx2);

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i] + " ");
            }

            Console.WriteLine("****************************************************");
            foreach (string s in lst)
                Console.WriteLine(s + " ");

          
        }
    }
}
