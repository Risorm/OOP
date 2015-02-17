using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_List
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
   AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]
  public class Version : Attribute
    {
        public int Minor { get; private set; }
        public int Major { get; private set; }
        public Version(int max, int min)
        {
            this.Minor = min;
            this.Major = max;
        }
    }
}
