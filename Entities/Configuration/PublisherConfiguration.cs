using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(                
                new Publisher {PublisherId=1, PublisherName= "No Starch Press" },
                new Publisher {PublisherId=2, PublisherName = "O'Reilly Media" },
                new Publisher {PublisherId=3, PublisherName = "Packt Publishing" },
                new Publisher {PublisherId=4,  PublisherName = "TCK Publishing" },
                new Publisher {PublisherId=5, PublisherName = "Reed Elsevier" },
                new Publisher {PublisherId=6, PublisherName = "Penguin Random House" },
                new Publisher {PublisherId=7, PublisherName = "Harper Collins" },
                new Publisher {PublisherId=8, PublisherName = "Simon & Schuster" },
                new Publisher {PublisherId=9, PublisherName = "Phoenix Publishing and Media Company" },
                new Publisher {PublisherId=10, PublisherName = "Phoenix Yard Books" },
                new Publisher {PublisherId=11, PublisherName = "Pan Macmillan" },
                new Publisher {PublisherId=12, PublisherName = "Bloomsbury" },
                new Publisher {PublisherId=13, PublisherName = "Arbordale Publishing" },
                new Publisher {PublisherId=14, PublisherName = "Arcade Publishing" },
                new Publisher {PublisherId=15, PublisherName = "Arcadia Publishing" },
                new Publisher {PublisherId=16, PublisherName = "B & W Publishing" },
                new Publisher {PublisherId=17, PublisherName = "Beacon Publishing" },
                new Publisher {PublisherId=18, PublisherName = "John Blake Publishing" },
                new Publisher {PublisherId=19, PublisherName = "Capstone Publishers" },
                new Publisher {PublisherId=20, PublisherName = "Flame Tree Publishing" },
                new Publisher {PublisherId=21, PublisherName = "Alfaguara" },
                new Publisher {PublisherId=22, PublisherName = "Educar Editores" },
                new Publisher {PublisherId=23, PublisherName = "Editorial Norma " },
                new Publisher {PublisherId=24, PublisherName = "Mc Graw Hill" },
                new Publisher {PublisherId=25, PublisherName = "Norma" },
                new Publisher {PublisherId=26, PublisherName = "Oxford" },
                new Publisher {PublisherId=27, PublisherName = "Pearson" },
                new Publisher {PublisherId=28, PublisherName = "Planeta" },
                new Publisher {PublisherId=29, PublisherName = "Random" },
                new Publisher {PublisherId=30, PublisherName = "Santillana" },
                new Publisher {PublisherId=31, PublisherName = "Books and Books" }
                );
        }
    }
}
