using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly LibraryContext _libraryContext;

        public UsersController(LibraryContext libraryContext)
        {
            this._libraryContext = libraryContext;
        }
    }
}
