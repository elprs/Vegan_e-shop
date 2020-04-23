using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities
{
    interface IProduct
    {
        int Id { get; set; }
        string Title { get; set; }
        decimal Price { get; set; }
    }
}
