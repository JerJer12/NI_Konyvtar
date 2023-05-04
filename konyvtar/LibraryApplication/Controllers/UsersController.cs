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

        /// <summary>
        ///     All the users with their datas.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            var users = await this._libraryContext.Users.ToListAsync();
            return this.Ok(users);
        }
    }
}
