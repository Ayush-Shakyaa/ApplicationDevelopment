using Domain.Bislerium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Bislerium
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetBlogById(Guid id);
        Task<IEnumerable<Blog>> GetAllBlog();
        Task<Blog> AddBlog(Blog blog);
        Task<Blog> UpdateBlog(Blog blog);
        Task DeleteBlog(Guid id);
    }
}
