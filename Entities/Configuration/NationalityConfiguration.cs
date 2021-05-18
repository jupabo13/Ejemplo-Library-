using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    class NationalityConfiguration : IEntityTypeConfiguration<Nationality>
    {
        public void Configure(EntityTypeBuilder<Nationality> builder)
        {
            builder.HasData(
                new Nationality { NationalityId = 1, CountryCode = "GB", NationalityName = "British" },
                new Nationality { NationalityId = 2, CountryCode = "AF", NationalityName = "Afghan" },
                new Nationality { NationalityId = 3, CountryCode = "AL", NationalityName = "Albanian" },
                new Nationality { NationalityId = 4, CountryCode = "DZ", NationalityName = "Algerian" },
                new Nationality { NationalityId = 5, CountryCode = "US", NationalityName = "American" }                
                );
        }
    }
}
