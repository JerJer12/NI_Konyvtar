using LibraryApplication.Contracts;
using System.Net.Http.Json;



namespace CustomerClient.Service.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _http;
        public CustomerService(HttpClient http) 
        {
            _http = http;
        }

        public Task<List<Book>?> GetBooks() => _http.GetFromJsonAsync<List<Book>>("https://localhost:7081/books");

        public Task<BookDetails> GetSingleBook(int id) => _http.GetFromJsonAsync<BookDetails>($"https://localhost:7081/books/{id}");

        public Task<List<Borrow>?> GetBorrows() => _http.GetFromJsonAsync<List<Borrow>>($"https://localhost:7081/borrows");

        public Task<List<Borrow>?> GetBorrowsForUser(int id) => _http.GetFromJsonAsync<List<Borrow>>($"https://localhost:7081/{id}/borrows");

        public Task AddBorrow(Borrow borrow) => _http.PostAsJsonAsync<Borrow>("https://localhost:7081/borrows", borrow);

        public Task DeleteBorrow(int id) => _http.DeleteAsync($"https://localhost:7081/borrows/{id}");

        public Task<User?> GetSingleUser(int id) => _http.GetFromJsonAsync<User>($"https://localhost:7081/users/{id}");

        public Task<List<User>?> GetUsers() => _http.GetFromJsonAsync<List<User>>("https://localhost:7081/users");


    }
}
