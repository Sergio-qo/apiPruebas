using cursoAPI.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace cursoAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public IActionResult GetPosts()
        {
            var posts = new PostRepository().GetPosts();
            return Ok(posts);
        }
    }
}
