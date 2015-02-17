using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_List
{
    class TestGenericList
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();
            list.Add(1);
            list.Add(5);
            list.Add(7);
            Console.WriteLine(list.Index(7));
            list.ClearList();
        }
    }
}
