using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    /// <summary>
    /// ישות מוצר
    /// בחנות התכשיטים
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Name"></param>
    /// <param name="Category"></param>
    /// <param name="Price"></param>
    /// <param name="CountStock"></param>
    internal record Product
        (
        int Id,
        string Name,
        Categories Category,
        double Price,
        int CountStock
        )
    {
        public Product():this(0,"",Categories.Earring,0.0,0)
        {
            
        }
    }
}
