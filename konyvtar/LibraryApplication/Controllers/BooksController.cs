using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : Controller
    {
        private readonly LibraryContext _libraryContext;

        public BooksController(LibraryContext libraryContext)
        {
            this._libraryContext = libraryContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> Get()
        {
            var books = await this._libraryContext.Books.ToListAsync();
            return this.Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var book = await this._libraryContext.Books
                .Where(b => b.InventoryNumber == id)
                .Select(b => new
                {
                    Title = b.Title,
                    Status = this._libraryContext.Borrows
                        .Where(br => br.InventoryNumber == id)
                        .Any() ? "borrowed" : "in",
                    BorrowerName = this._libraryContext.Borrows
                        .Where(br => br.InventoryNumber == id)
                        .Join(
                            this._libraryContext.Users,
                            br => br.ReaderNumber,
                            u => u.ReaderNumber,
                            (br, u) => u.Name)
                        .FirstOrDefault(),
                    ReturnDate = this._libraryContext.Borrows
                        .Where(br => br.InventoryNumber == id)
                        .Select(br => br.ReturnDate)
                        .FirstOrDefault(),
                })
                .FirstOrDefaultAsync();

            if (book is null)
            {
                return this.NotFound();
            }

            return this.Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Book book)
        {
            this._libraryContext.Books.Add(book);
            await this._libraryContext.SaveChangesAsync();

            return this.Ok();
        }
    }
}
