using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace LibraryApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BorrowsController : Controller
    {
        private readonly LibraryContext _libraryContext;

        public BorrowsController(LibraryContext libraryContext)
        {
            this._libraryContext = libraryContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Borrow>>> Get()
        {
            var borrows = from borrow in this._libraryContext.Borrows
                        join people in this._libraryContext.Users on borrow.ReaderNumber equals people.ReaderNumber
                        join book in this._libraryContext.Books on borrow.InventoryNumber equals book.InventoryNumber
                        select new
                        {
                            BorrowNumber = borrow.BorrowNumber,
                            Name = people.Name,
                            BookTitle = book.Title,
                            BorrowDate = borrow.BorrowDate,
                            ReturnDate = borrow.ReturnDate,
                        };
            return this.Ok(borrows);
        }
    }
}