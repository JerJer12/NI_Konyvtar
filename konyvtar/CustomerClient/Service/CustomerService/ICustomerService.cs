

using LibraryApplication.Contracts;

namespace CustomerClient.Service.CustomerService
{
    public interface ICustomerService
    {

        Task<List<Book>?> GetBooks();

        Task<BookDetails> GetSingleBook(int id);

        Task<List<Borrow>?> GetBorrows();

        Task<List<Borrow>?> GetBorrowsForUser(int id);

        Task AddBorrow(Borrow borrow);

        Task DeleteBorrow(int id);

    }
}
