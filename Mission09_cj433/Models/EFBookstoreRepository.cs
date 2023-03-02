using System.Linq;

namespace Mission09_cj433.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository (BookstoreContext temp) => context = temp;

        public IQueryable<Book> Books => context.Books;
    }
}