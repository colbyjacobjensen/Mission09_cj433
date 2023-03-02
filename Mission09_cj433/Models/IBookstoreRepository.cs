using System.Linq;

namespace Mission09_cj433.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}