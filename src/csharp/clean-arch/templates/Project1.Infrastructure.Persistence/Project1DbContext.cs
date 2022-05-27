using Microsoft.EntityFrameworkCore;

namespace Project1.Infrastructure.Persistence;
public class Project1DbContext : DbContext
{
    public Project1DbContext(DbContextOptions<Project1DbContext> options) : base(options)
    {

    }
}