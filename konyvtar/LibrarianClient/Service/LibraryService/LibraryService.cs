using System.Net.Http.Json;

namespace LibrarianClient.Service.LibraryService
{
    public class LibraryService : ILibraryService
    {
        private readonly HttpClient _http;
        public LibraryService(HttpClient http) { 
            _http = http;
        }

        public List<User> users { get; set; } = new List<User>();
        public List<Book> books { get; set; } = new List<Book>();
        public List<Borrow> borrows { get; set; } = new List<Borrow>();

        public async Task GetBooks()
        {
            var result = await _http.GetFromJsonAsync<List<Book>>("https://localhost:7081/books");
            if (result != null)
            {
                books = result;
            }
        }

        public Task GetBorrows()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetSingleUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetUsers()
        {
            var result = await _http.GetFromJsonAsync<List<User>>("https://localhost:7081/users");
            if (result != null)
            {
                users = result;
            }
        }

        public async Task AddUser(User user)
        {
            var response = await _http.PostAsJsonAsync("http://localhost:7081/users", user);
            var result = await response.Content.ReadFromJsonAsync<List<User>>();
            users = result;
        }

        public async Task DeleteUser(int id)
        {
            var response = await _http.DeleteAsync($"http://localhost:7081/users/{id}");
            var result = await response.Content.ReadFromJsonAsync<List<User>>();
            users = result;
        }
    }
}
