using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kek.DATA.Entities
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }
        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
