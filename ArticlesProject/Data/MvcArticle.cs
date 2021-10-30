using Microsoft.EntityFrameworkCore;
using ArticlesProject.Models;

namespace ArticlesProject.Data
{
    public class MvcArticleContext : DbContext
    {
        public MvcArticleContext (DbContextOptions<MvcArticleContext> options) : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
    }
}
