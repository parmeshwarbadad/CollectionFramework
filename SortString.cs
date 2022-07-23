using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionFramework
{
    class SortString
    {
        static bool Isadd(int n)
        {
            return n % 2 == 1;
        }
        static void Main(string[] args)
        {
           /* List<string> lst = new List<string>() { "deepa", "Medha", "Kirti" };
            lst.Sort();
            lst.Reverse();
            foreach(string s in lst)
                Console.WriteLine(s+" ");*/

            List<int> l2 = new List<int>() { 23, 44, 56, 77, 89, 90, 53 };
            List<int> oddlist = l2.FindAll(Isadd);

            foreach (int s in oddlist)
                Console.WriteLine(s + " ");


        }
    }
}
