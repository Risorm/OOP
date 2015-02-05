using System;
using System.Security.Cryptography.X509Certificates;
using Multimedia_Shop.Models;

namespace Multimedia_Shop.Interfaces
{
    interface IRentable
    {
        Item RentItem { get; }
        RentState RentState { get; }
        DateTime RentDate { get;}
        DateTime Deadline { get;}
        DateTime ReturnDate { get;}
        decimal CalculateRentFIne(DateTime RentDate ,DateTime Deadline , DateTime ReturnDate );
    }
}
