namespace LibrarianClient.Service.LibraryService
{
    public interface ILibraryService
    {
        List<User> users { get; set; }
        List<Book> books { get; set; }
        List<Borrow> borrows { get; set; }

        Task GetUsers();

        Task GetBooks();

        Task GetBorrows();

        Task<User> GetSingleUser(int id);

        Task AddUser(User user);
    }
}