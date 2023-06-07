using Shop_Auto.Data.Models;
using System.Collections.Generic;

namespace Shop_Auto.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}