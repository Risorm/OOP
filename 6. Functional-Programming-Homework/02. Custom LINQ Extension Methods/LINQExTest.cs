using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Custom_LINQ_Extension_Methods
{
    static class LINQExTest
    {
        static void Main()
        {
            var words = new List<string> { "one", "two", "three", "four", "five", "six" };
            var whereNotCollection = string.Join(", ", words.WhereNot(w => w == "six"));
            Console.WriteLine(whereNotCollection);
            var repeatCollection = string.Join(", ", words.Repeat(2));
            Console.WriteLine(repeatCollection);
            var suffixes = new List<string>() { "ne", "ree" };
            var endsWithCollection = string.Join(", ", words.WhereEndsWith(suffixes));
            Console.WriteLine(endsWithCollection);
        }
    }
}