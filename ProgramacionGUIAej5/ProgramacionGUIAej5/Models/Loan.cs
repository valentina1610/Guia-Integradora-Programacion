using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionGUIAej5.Models
{
    public class Loan
    {
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }

        public Loan() { }
        public Loan(Book book, User user)
        {
            this.Book = book;
            this.User = user;
            this.Date = DateTime.Now;
        }
    }
}
