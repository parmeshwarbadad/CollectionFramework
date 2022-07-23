using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionFramework
{
    class DemoDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Param", 89);
            dd.Add("Anuj", 87);
            dd.Add("Ajinkya", 99);
            dd.Add("Pralhad", 87);
            dd.Add("Om", 99);

            dd["Ajinkya"] = 90;
            dd.Remove("Anuj");

            Console.WriteLine(dd.Count);
            //dd.clear();
            Console.WriteLine(dd.ContainsKey ("Om"));
            Console.WriteLine(dd.ContainsValue (87));

            //List<string> keys = dd.Keys.ToList();

            Console.WriteLine(dd["Pralhad"]);

            foreach (KeyValuePair <string ,int> kv in dd)
                Console.WriteLine(kv.Key+" "+kv.Value);

        }
    }
}
