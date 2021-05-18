using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {   PublicationId = 1,
                    ISBN = "9781593275846",
                    Title = "Eloquent JavaScript, Second Edition",
                    SubTitle = "A Modern Introduction to Programming",
                    Published = new DateTime(2014, 12, 14),
                    PublisherId = 1,
                    NumberOfPages = 472,
                    FormatId = 1,
                    Description = "JavaScript lies at the heart of almost every modern web application, from social apps to the newest browser-based games. Though simple for beginners to pick up and play with, JavaScript is a flexible, complex language that you can use to build full-scale applications.",
                    WebSite = "http://eloquentjavascript.net/"
                },
                 new Book
                 {
                     PublicationId = 2,
                     ISBN = "9781449331818",
                     Title = "Learning JavaScript Design Patterns",
                     SubTitle = "A JavaScript and jQuery Developer's Guide",
                     Published = new DateTime(2012, 07, 01),
                     PublisherId = 2,
                     NumberOfPages = 254,
                     FormatId = 1,
                     Description = "With Learning JavaScript Design Patterns, you'll learn how to write beautiful, structured, and maintainable JavaScript by applying classical and modern design patterns to the language. If you want to keep your code efficient, more manageable, and up-to-date with the latest best practices, this book is for you.",
                     WebSite = "http://www.addyosmani.com/resources/essentialjsdesignpatterns/book/"
                 },
                  new Book
                  {
                      PublicationId = 3,
                      ISBN = "9781449365035",
                      Title = "Speaking JavaScript",
                      SubTitle = "An In-Depth Guide for Programmers",
                      Published = new DateTime(2014, 02, 01),
                      PublisherId = 2,
                      NumberOfPages = 460,
                      FormatId = 1,
                      Description = "Like it or not, JavaScript is everywhere these days-from browser to server to mobile-and now you, too, need to learn the language or dive deeper than you have. This concise book guides you into and through JavaScript, written by a veteran programmer who once found himself in the same position.",
                      WebSite = "http://speakingjs.com/"
                  },
                  new Book
                  {
                      PublicationId = 4,
                      ISBN = "9781491950296",
                      Title = "Programming JavaScript Applications",
                      SubTitle = "Robust Web Architecture with Node, HTML5, and Modern JS Libraries",
                      Published = new DateTime(2014, 07, 01),
                      PublisherId = 2,
                      NumberOfPages = 254,
                      FormatId = 1,
                      Description = "Take advantage of JavaScript's power to build robust web-scale or enterprise applications that are easy to extend and maintain. By applying the design patterns outlined in this practical book, experienced JavaScript developers will learn how to write flexible and resilient code that's easier-yes, easier-to work with as your code base grows.",
                      WebSite = "http://chimera.labs.oreilly.com/books/1234000000262/index.html"
                  },
                   new Book
                   {
                       PublicationId = 5,
                       ISBN = "9781593277574",
                       Title = "Understanding ECMAScript 6",
                       SubTitle = "The Definitive Guide for JavaScript Developers",
                       Published = new DateTime(2016, 09, 03),
                       PublisherId = 1,
                       NumberOfPages = 278,
                       FormatId =1,
                       Description = "ECMAScript 6 represents the biggest update to the core of JavaScript in the history of the language. In Understanding ECMAScript 6, expert developer Nicholas C. Zakas provides a complete guide to the object types, syntax, and other exciting changes that ECMAScript 6 brings to JavaScript.",
                       WebSite = "https://leanpub.com/understandinges6/read"
                   }
                ); 
        }
    }
}
