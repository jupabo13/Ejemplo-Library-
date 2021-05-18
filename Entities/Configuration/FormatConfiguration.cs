using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class FormatConfiguration : IEntityTypeConfiguration<Format>
    {
        public void Configure(EntityTypeBuilder<Format> builder)
        {
            builder.HasData(
                new Format { FormatId= 1, FormatName = "Printed" },
                new Format { FormatId= 2, FormatName = "CD"},
                new Format { FormatId= 3, FormatName = "DVD"},
                new Format { FormatId= 4, FormatName = "BluRay"}
                );
        }
    }
}
