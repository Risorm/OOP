using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multimedia_Shop.Models;

namespace Multimedia_Shop.Interfaces
{
    interface ISaleable
    {
        Item SaleItem { get; }
        DateTime SaleDate { get;}
    }
}
