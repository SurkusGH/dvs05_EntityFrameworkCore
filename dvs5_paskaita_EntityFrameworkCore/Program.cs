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
            // Console.WriteLine("dvs5_paskaita_EntityFrameworkCore!");
            using var dbContext = new BookContext();
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
            var book = dbContext.Books.Where(book => book.Id == new Guid("4BF9F9C5-F7A4-44A8-89F4-82120C6F4704")).Include(x => x.Pages).First();
            dbContext.Books.Remove(book);

            dbContext.SaveChanges();
        }
    }
}
