using kek.DATA.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kek.DATA.Organize
{
    public class SellMap
    {
        public SellMap(EntityTypeBuilder<Sell> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.SellerId);
            builder.Property(m => m.ProductId);
        }
    }
}
