using Microsoft.EntityFrameworkCore;

namespace Project1.Infrastructure.Persistence;
public class Project1ShortNameDbContext : DbContext
{
    public Project1ShortNameDbContext(DbContextOptions<Project1ShortNameDbContext> options) : base(options)
    {

    }
}