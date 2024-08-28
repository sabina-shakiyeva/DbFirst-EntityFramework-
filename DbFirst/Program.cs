using DbFirst.Context;

namespace DbFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library2Context library = new Library2Context();
            LibraryService libraryService = new LibraryService(library);
            libraryService.GetAllBooks();
        }
    }
}
