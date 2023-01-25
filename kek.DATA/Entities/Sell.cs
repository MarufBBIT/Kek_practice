using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kek.DATA.Entities
{
    public class Sell:BaseEntity
    {
        public int ProductId { get; set; }
        public long Price { get; set; }
        public string SellerId { get; set; }
    }
}
