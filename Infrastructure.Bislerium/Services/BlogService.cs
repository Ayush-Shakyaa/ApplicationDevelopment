using Application.Bislerium;
using Domain.Bislerium.Models;
using Infrastructure.Bislerium.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Bislerium
{
    public class BlogService : IBlogService
    {
            private readonly ApplicationDbContext _context;

            public BlogService(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Blog> AddBlog(Blog blog)
            {
                await _context.Blog.AddAsync(blog);
                await _context.SaveChangesAsync();
                return blog;
            }

            public async Task DeleteBlog(Guid id)
            {
                var result = await _context.Blog.FindAsync(id);
                if (result != null)
                {
                    _context.Blog.Remove(result);
                    await _context.SaveChangesAsync();
                }
            }

            public async Task<IEnumerable<Blog>> GetAllBlog()
            {
                return await _context.Blog.ToListAsync();
            }

            public Task<IEnumerable<Blog>> GetBlogById(Guid id)
            {
                throw new NotImplementedException();
            }

            public async Task<IEnumerable<Blog>> GetBlogtById(Guid id)
            {
                return await _context.Blog.Where(b => b.Id == id).ToListAsync();
            }

            public async Task<Blog> UpdateBlog(Blog blog)
            {
                _context.Entry(blog).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return blog;
            }
        }

    }
