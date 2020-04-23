using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities.Home
{
    class Home 
    {
        //RELATIONSHIPS
        // Candle ---  0-m 

        //Navigation Property
        public virtual ICollection<Candle> Candles { get; set; }
    }
}
