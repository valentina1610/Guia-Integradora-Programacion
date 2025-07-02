using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaExamen7.Repository;
using ProgramacionGUIAej5.Models;
using ProgramacionGUIAej5.Utils;
using ProgramacionGUIAej5.Views;

namespace ProgramacionGUIAej5.Controllers
{
    public class LoanController
    {
        UserController uController = new();
        BookController bController = new();

        // LISTA DE LIBROS DISPONIBLES
        private List<Book> availableBooks = new();

        // LISTA DE LIBROS PRESTADOS
        private List<Loan> loansList;

        public LoanController()
        {
            loansList = new();
            Load();
        }


        private void Load()
        {
            availableBooks = Repository<Book>.ObtenerTodos(Path.Combine("Repository", "Data", "books"));
            loansList = Repository<Loan>.ObtenerTodos(Path.Combine("Repository", "Data", "loans"));
        }

        private void Save()
        {
            Repository<Book>.GuardarLista(Path.Combine("Repository", "Data", "books"), availableBooks);
            Repository<Loan>.GuardarLista(Path.Combine("Repository", "Data", "loans"), loansList);
        }

        public void LendBook()
        {
            if (availableBooks.Count == 0)
            {
                Utils.Utils.ShowMsg("[ERROR]: Empty list of books");
                return;
            }
            var newUser = uController.AddUser();
            if (newUser == null)
            {
                Utils.Utils.ShowMsg("[ERROR]: null user, press any key to continue.");
                Console.ReadKey();
                return;
            }
            bController.ShowBooks(availableBooks);
            Utils.Utils.ShowMsg("Enter the ISBN of the book you want to lend:");
            string isbn = Utils.Utils.getValidInput(true);

            var book = availableBooks.FirstOrDefault(b => b.ISBN == isbn);

            if (book != null && book.Available)
            {
                // Marcar como no disponible
                book.Available = false;

                // Crear objeto prestamo
                var loan = new Loan(book, newUser);

                // Agregar a la lista de prestamos
                loansList.Add(loan);

                // Eliminar de la lista de disponibles
                availableBooks.Remove(book);

                Utils.Utils.ShowMsg("[SUCCESS]: Book has been lent successfully! Press any key to continue.");
            }
            else
            {
                Utils.Utils.ShowMsg("[ERROR]: Book not found. Press any key to continue.");
            }
            Save();

        }

        public void ShowBooks()
        {
            if (availableBooks.Count == 0)
            {
                Utils.Utils.ShowMsg("[ERROR]: Empty list of books.");
                return;
            }
            bController.ShowBooks(availableBooks);
        }

        public void ReturnBook()
        {
            if (loansList.Count == 0)
            {
                Utils.Utils.ShowMsg("[ERROR]: Empty list of loans");
                return;
            }
            LoanView.ShowLoans(loansList);
            Utils.Utils.ShowMsg("Enter the ISBN of the book you want to return:");
            string isbn = Utils.Utils.getValidInput(true);

            var bookToReturn = loansList.FirstOrDefault(l => l.Book.ISBN == isbn);

            if (bookToReturn != null)
            {
                // Marcar como disponible
                bookToReturn.Book.Available = true;

                // Agregar el libro a la lista de disponibles
                availableBooks.Add(bookToReturn.Book);

                // Remover el prestamo de la lista
                loansList.Remove(bookToReturn);

                Utils.Utils.ShowMsg("[SUCCESS]: Book returned successfully! Press any key to continue.");
                Save();
            }
            else
            {
                Utils.Utils.ShowMsg("[ERROR]: Book not found. Press any key to continue.");
            }
        }

        public void UpdateBook()
        {
            if (availableBooks.Count == 0)
            {
                Utils.Utils.ShowMsg("[ERROR]: Empty list of books.");
                return;
            }

            // Mostrar libros disponibles
            bController.ShowBooks(availableBooks);

            Utils.Utils.ShowMsg("Enter the ISBN of the book you want to update:");
            string isbn = Utils.Utils.getValidInput(true);

            var bookToUpdate = availableBooks.FirstOrDefault(b => b.ISBN == isbn);

            if (bookToUpdate != null)
            {
                //crear nuevo libro
                var newBook = bController.CreateBook();

                //reemplazar datos
                bookToUpdate.Title = newBook.Title;
                bookToUpdate.Author = newBook.Author;
                bookToUpdate.ISBN = newBook.ISBN;

                Save();
                Utils.Utils.ShowMsg("[SUCCESS]: Book updated successfully! Press any key to continue.");
            }
            else
            {
                Utils.Utils.ShowMsg("[ERROR]: Book not found. Press any key to continue.");
            }
        }
    }
}
