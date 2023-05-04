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
    }
}