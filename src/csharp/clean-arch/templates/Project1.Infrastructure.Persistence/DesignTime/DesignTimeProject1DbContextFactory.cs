using Microsoft.EntityFrameworkCore.Design;

namespace Project1.Infrastructure.Persistence.DesignTime;
public class DesignTimeProject1DbContextFactory : IDesignTimeDbContextFactory<Project1DbContext>
{
    public Project1DbContext CreateDbContext(string[] args)
    {
        throw new NotImplementedException();
    }
}