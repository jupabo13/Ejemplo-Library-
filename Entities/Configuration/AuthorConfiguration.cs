using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author { AuthorId=1, FirstName= "Marijn", LastName= "Haverbeke", NationalityId = 1},
                new Author { AuthorId=2, FirstName = "Addy", LastName = "Osmani", NationalityId = 2 },               
                new Author { AuthorId=3, FirstName = "Axel", LastName = "Rauschmayer", NationalityId = 1 },
                new Author { AuthorId=4, FirstName = "Eric", LastName = "Elliott", NationalityId = 1 },
                new Author { AuthorId=5, FirstName = "Nicholas C", LastName = "Zakas", NationalityId = 1 },
                new Author { AuthorId=6, FirstName = "Kyle", LastName = "Simpson", NationalityId = 1 },
                new Author { AuthorId=7, FirstName = "Richard E", LastName = "Silverman", NationalityId = 1 },
                new Author { AuthorId=8, FirstName = "Glenn", LastName = "Block", NationalityId = 1 }
                );
        }
    }
}
