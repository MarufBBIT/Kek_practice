using kek.DATA.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kek.DATA.Organize
{
    public class CategoryMap
    {
        public CategoryMap(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Name);
        }
    }
}
