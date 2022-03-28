using dvs5_paskaita_EntityFrameworkCore.Contexts;
using dvs5_paskaita_EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace dvs5_paskaita_EntityFrameworkCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dvs5_paskaita_EntityFrameworkCore!");

            #region TEORIJA
            //using var dbContext = new BookContext();
            // Rašom
            //var page = new Page(1, "Text, text");
            //dbContext.Pages.Add(page);


            // Trinam
            //var page = new Page(new Guid("F76C9781-C42A-4ED2-A724-83DA757DB5DB"));
            //dbContext.Pages.Remove(page);

            // Rašom
            //var book = new Book("Harry Potter");
            //for (int i = 0; i < 566; i++)
            //{
            //    book.Pages.Add(new Page(i, $"Text, text- {i}"));
            //}
            //dbContext.Books.Add(book);

            // Trinam
            //var book = dbContext.Books.Where(book => book.Id == new Guid("4BF9F9C5-F7A4-44A8-89F4-82120C6F4704")).Include(x => x.Pages).First();
            //dbContext.Books.Remove(book);

            //dbContext.SaveChanges();
            #endregion

            //WriteTo_DB();
            //DeleteFrom_DB();
            //WriteTo_DB_BookAndPages();
            DeleteFrom_DB_BookAndPages();
        }
        public static void WriteTo_DB()
        {
            using var dbContext = new BookContext();
            var page = new Page(1, "J. K. Rawling");
            dbContext.Pages.Add(page);
            dbContext.SaveChanges();
        }
        /// <summary>
        /// Guid should be found in SSMS DB table (for targeting the row that is to be deleted
        /// </summary>
        public static void DeleteFrom_DB()
        {
            using var dbContext = new BookContext();
            var page = new Page(new Guid("306463F0-A1D4-4387-9C60-4C09E6D59980")); 
            dbContext.Pages.Remove(page);
            dbContext.SaveChanges();
        }
        public static void WriteTo_DB_BookAndPages()
        {
            using var dbContext = new BookContext();
            var book = new Book("Harry Potter");
            for (int i = 0; i < 400; i++)
            {
                book.Pages.Add(new Page(i, $"J. K. Rawling {i}"));
            }
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
        }
        public static void DeleteFrom_DB_BookAndPages()
        {
            using var dbContext = new BookContext();
            var book = dbContext.Books.Where(book => book.Id == new Guid("7A14C3C4-B994-4010-9630-2526724C797F")).Include(x => x.Pages).First();
            dbContext.Books.Remove(book);

            dbContext.SaveChanges();
        }
    }
}
