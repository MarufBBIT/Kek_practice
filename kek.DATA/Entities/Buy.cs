using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kek.DATA.Entities
{
    public class Buy : BaseEntity
    {
        public int ProductId { get; set; }
        public long Price { get; set; }
        public string BuyerId { get; set; }
    }
}
