namespace LibrarianClient.Service.LibraryService
{
    public interface ILibraryService
    {

        Task<List<User>?> GetUsers();

        Task<List<Book>?> GetBooks();

        Task<BookDetails> GetSingleBook(int id);

        Task<List<Borrow>?> GetBorrows();

        Task<List<Borrow>?> GetBorrowsForUser(int id);

        Task AddBorrow(Borrow borrow);

        Task DeleteBorrow(int id);

        Task<User?> GetSingleUser(int id);

        Task AddUser(User user);

        Task UpdateUser(int id, User user);

        Task DeleteUser(int id);
    }
}