using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LibrarianClient.Service.LibraryService
{
    public class LibraryService : ILibraryService
    {
        private readonly HttpClient _http;
        public LibraryService(HttpClient http) { 
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

        public Task AddUser(User user) => _http.PostAsJsonAsync("http://localhost:7081/users", user);

        public Task UpdateUser(int id, User user) => _http.PutAsJsonAsync($"http://localhost:7081/users/{id}", user);

        public Task DeleteUser(int id) => _http.DeleteAsync($"http://localhost:7081/users/{id}");
    }
}
