using System;
using System.Collections.Generic;


namespace Multimedia_Shop.Interfaces
{
    interface IItem : IRentable, ISaleable
    {
        string ItemId { get; }
        string Title { get; }
        decimal Price { get; }
        List<string> Genres { get; }
    }
}
