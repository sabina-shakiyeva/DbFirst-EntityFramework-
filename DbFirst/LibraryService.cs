using DbFirst.Context;
using Microsoft.EntityFrameworkCore;

namespace DbFirst
{
    public class LibraryService
    {
        private readonly Library2Context _context;

        public LibraryService(Library2Context context)
        {
            _context = context;
        }

        public void GetAllBooks() {
            //_context.Books.ForEachAsync(book => { Console.WriteLine(book); });
            if (_context == null)
            {
                Console.WriteLine("DbContext is not initalized");
                return;
            }
            var books = _context.Books.Select(x => new { x.Id, x.Name }).ToList();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}: {book.Name}");
            }
        }
    }
}
