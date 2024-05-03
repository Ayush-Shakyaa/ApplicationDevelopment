
using Application.Bislerium;
using Domain.Bislerium.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.BisleriumApi.Controllers
{
    public class BlogController : Controller
    {

        private readonly IBlogService _BlogService;

        public BlogController(IBlogService blogService)
        {
            _BlogService = blogService;
        }

        [HttpPost, Route("AddBlog")]
        public async Task<IActionResult> AddBlog(Blog
            blog)
        {
            var result = await _BlogService.AddBlog(blog);
            return Ok(result);
        }

        [HttpGet, Route("GetBlog")]
        public async Task<IActionResult> GetABlog(Guid id)
        {
            var result = await _BlogService.GetBlogById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet, Route("GetBlogs")]
        public async Task<IActionResult> GetAllBlog()
        {
            var result = await _BlogService.GetAllBlog();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete, Route("DeleteBlog")]
        public async Task<IActionResult> DeleteBlog(Guid Id)
        {
            await _BlogService.DeleteBlog(Id);

            return Ok();
        }

        [HttpPut, Route("UpdateBlog")]
        public async Task<IActionResult> UpdateBlog(Blog blog)
        {
            var result = await _BlogService.UpdateBlog(blog);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}

