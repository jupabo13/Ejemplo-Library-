using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.API.Migrations
{
    public partial class ImplementSeed01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Format",
                columns: new[] { "FormatId", "FormatName" },
                values: new object[,]
                {
                    { 1, "Printed" },
                    { 2, "CD" },
                    { 3, "DVD" },
                    { 4, "BluRay" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "PublisherName" },
                values: new object[,]
                {
                    { 9, "Phoenix Publishing and Media Company" },
                    { 13, "Arbordale Publishing" },
                    { 14, "Arcade Publishing" },
                    { 15, "Arcadia Publishing" },
                    { 16, "B & W Publishing" },
                    { 17, "Beacon Publishing" },
                    { 18, "John Blake Publishing" },
                    { 19, "Capstone Publishers" },
                    { 20, "Flame Tree Publishing" },
                    { 23, "Editorial Norma " },
                    { 22, "Educar Editores" },
                    { 12, "Bloomsbury" },
                    { 24, "Mc Graw Hill" },
                    { 25, "Norma" },
                    { 26, "Oxford" },
                    { 27, "Pearson" },
                    { 28, "Planeta" },
                    { 29, "Random" },
                    { 21, "Alfaguara" },
                    { 11, "Pan Macmillan" },
                    { 31, "Books and Books" },
                    { 30, "Santillana" },
                    { 8, "Simon & Schuster" },
                    { 7, "Harper Collins" },
                    { 6, "Penguin Random House" },
                    { 5, "Reed Elsevier" },
                    { 4, "TCK Publishing" },
                    { 3, "Packt Publishing" },
                    { 2, "O'Reilly Media" },
                    { 1, "No Starch Press" },
                    { 10, "Phoenix Yard Books" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Nationality",
                columns: new[] { "NationalityId", "CountryCode", "NationalityName" },
                values: new object[,]
                {
                    { 1, "GB", "British" },
                    { 2, "AF", "Afghan" },
                    { 5, "US", "American" },
                    { 4, "DZ", "Algerian" },
                    { 3, "AL", "Albanian" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Publication",
                column: "PublicationId",
                values: new object[]
                {
                    5,
                    4
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Publication",
                column: "PublicationId",
                value: 3);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Publication",
                column: "PublicationId",
                value: 2);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Publication",
                column: "PublicationId",
                value: 1);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "LastName", "NationalityId" },
                values: new object[,]
                {
                    { 1, "Marijn", "Haverbeke", 1 },
                    { 3, "Marijn", "Haverbeke", 1 },
                    { 4, "Axel", "Rauschmayer", 1 },
                    { 5, "Eric", "Elliott", 1 },
                    { 6, "Nicholas C", "Zakas", 1 },
                    { 7, "Kyle", "Simpson", 1 },
                    { 8, "Richard E", "Silverman", 1 },
                    { 9, "Glenn", "Block", 1 },
                    { 2, "Addy", "Osmani", 2 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Book",
                columns: new[] { "PublicationId", "Description", "FormatId", "ISBN", "NumberOfPages", "Published", "PublisherId", "SubTitle", "Title", "WebSite" },
                values: new object[,]
                {
                    { 1, "JavaScript lies at the heart of almost every modern web application, from social apps to the newest browser-based games. Though simple for beginners to pick up and play with, JavaScript is a flexible, complex language that you can use to build full-scale applications.", 1, "9781593275846", 472, new DateTime(2014, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "A Modern Introduction to Programming", "Eloquent JavaScript, Second Edition", "http://eloquentjavascript.net/" },
                    { 5, "ECMAScript 6 represents the biggest update to the core of JavaScript in the history of the language. In Understanding ECMAScript 6, expert developer Nicholas C. Zakas provides a complete guide to the object types, syntax, and other exciting changes that ECMAScript 6 brings to JavaScript.", 1, "9781593277574", 278, new DateTime(2016, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "The Definitive Guide for JavaScript Developers", "Understanding ECMAScript 6", "https://leanpub.com/understandinges6/read" },
                    { 2, "With Learning JavaScript Design Patterns, you'll learn how to write beautiful, structured, and maintainable JavaScript by applying classical and modern design patterns to the language. If you want to keep your code efficient, more manageable, and up-to-date with the latest best practices, this book is for you.", 1, "9781449331818", 254, new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "A JavaScript and jQuery Developer's Guide", "Learning JavaScript Design Patterns", "http://www.addyosmani.com/resources/essentialjsdesignpatterns/book/" },
                    { 3, "Like it or not, JavaScript is everywhere these days-from browser to server to mobile-and now you, too, need to learn the language or dive deeper than you have. This concise book guides you into and through JavaScript, written by a veteran programmer who once found himself in the same position.", 1, "9781449365035", 460, new DateTime(2014, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "An In-Depth Guide for Programmers", "Speaking JavaScript", "http://speakingjs.com/" },
                    { 4, "Take advantage of JavaScript's power to build robust web-scale or enterprise applications that are easy to extend and maintain. By applying the design patterns outlined in this practical book, experienced JavaScript developers will learn how to write flexible and resilient code that's easier-yes, easier-to work with as your code base grows.", 1, "9781491950296", 254, new DateTime(2014, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Robust Web Architecture with Node, HTML5, and Modern JS Libraries", "Programming JavaScript Applications", "http://chimera.labs.oreilly.com/books/1234000000262/index.html" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AuthorBook",
                columns: new[] { "AuthorId", "PublicationId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 5, 5 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "PublicationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "PublicationId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "PublicationId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "PublicationId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "AuthorBook",
                keyColumns: new[] { "AuthorId", "PublicationId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Nationality",
                keyColumn: "NationalityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Nationality",
                keyColumn: "NationalityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Nationality",
                keyColumn: "NationalityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Book",
                keyColumn: "PublicationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Book",
                keyColumn: "PublicationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Book",
                keyColumn: "PublicationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Book",
                keyColumn: "PublicationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Book",
                keyColumn: "PublicationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Format",
                keyColumn: "FormatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Nationality",
                keyColumn: "NationalityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Nationality",
                keyColumn: "NationalityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Publication",
                keyColumn: "PublicationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Publication",
                keyColumn: "PublicationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Publication",
                keyColumn: "PublicationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Publication",
                keyColumn: "PublicationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Publication",
                keyColumn: "PublicationId",
                keyValue: 5);
        }
    }
}
