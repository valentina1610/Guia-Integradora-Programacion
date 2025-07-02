using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaExamen7.Repository;
using ProgramacionGUIAej5.Models;
using ProgramacionGUIAej5.Views;

namespace ProgramacionGUIAej5.Controllers
{
    public class BookController
    {
        public void ShowBooks(List<Book> list) => BookView.ShowBooks(list);

        public Book CreateBook() => BookView.CreateBook();

    }
}
