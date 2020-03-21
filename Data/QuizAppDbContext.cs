using Microsoft.EntityFrameworkCore;
using QuizApp.API.Models;

namespace QuizApp.API.Data
{
    public class QuizAppDbContext : DbContext
    {
         public QuizAppDbContext(DbContextOptions<QuizAppDbContext> options) : base (options) {}
        public DbSet<Question> Questions { get; set; }
    }
}