using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace dvs5_paskaita_EntityFrameworkCore.Models
{
    public class Page
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Content { get; set; }

        [ForeignKey("Book")]
        public Guid BookID { get; set; }
        public Book Book { get; set; }

        public Page(int number, string content)
        {
            Id = Guid.NewGuid();
            Number = number;
            Content = content;
        }

        public Page(Guid id)
        {
            Id = id;
        }
    }
}
