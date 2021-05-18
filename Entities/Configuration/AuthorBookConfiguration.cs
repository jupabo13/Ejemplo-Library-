using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class AuthorBookConfiguration : IEntityTypeConfiguration<AuthorBook>
    {
        public void Configure(EntityTypeBuilder<AuthorBook> builder)
        {
            builder.HasData(
                new AuthorBook { AuthorId = 1, PublicationId = 1 },
                new AuthorBook { AuthorId = 2, PublicationId = 2 },
                new AuthorBook { AuthorId = 3, PublicationId = 3 },
                new AuthorBook { AuthorId = 4, PublicationId = 4 },
                new AuthorBook { AuthorId = 5, PublicationId = 5 }               
                );
        }
    }
}
