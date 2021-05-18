using Entities.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LibraryDbContext : IdentityDbContext
    {
        public LibraryDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public LibraryDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AuthorBook>()
                .HasKey(ab => new { ab.PublicationId, ab.AuthorId });
            modelBuilder.Entity<AuthorBook>()
                .HasOne(ab => ab.Book)
                .WithMany(b => b.AuthorsBook)
                .HasForeignKey(ab => ab.PublicationId);
            modelBuilder.Entity<AuthorBook>()
                .HasOne(ab => ab.Author)
                .WithMany(a => a.AuthorBooks)
                .HasForeignKey(ab => ab.AuthorId);

            modelBuilder.Entity<Format>()
            .Property("State")
            .HasDefaultValue(true);

            modelBuilder.Entity<Nationality>()
            .Property("State")
            .HasDefaultValue(true);

            modelBuilder.Entity<Publisher>()
           .Property("State")
           .HasDefaultValue(true);


            /*Seed */
            modelBuilder.ApplyConfiguration(new NationalityConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());
            modelBuilder.ApplyConfiguration(new FormatConfiguration());

            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorBookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            /* Fin seed */

        }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Format> Format { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorBook> AuthorBook { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Copy> Copy { get; set; }
        public DbSet<Magazine> Magazine { get; set; }
        public DbSet<Publication> Publication { get; set; }
        public DbSet<Shelf> Shelf { get; set; }
        public DbSet<Shelving> Shelving { get; set; }
    }
}
