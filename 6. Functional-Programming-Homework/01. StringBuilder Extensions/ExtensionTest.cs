using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StringBuilder_Extensions
{
    static class ExtensionTest
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder("This is a test string.");
            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, 4, 5};
            Console.WriteLine(sb.Substring(2, 9));
            Console.WriteLine(sb.RemoveText("test"));
            Console.WriteLine(sb.AppendAll(numbers));
        }
    }
}