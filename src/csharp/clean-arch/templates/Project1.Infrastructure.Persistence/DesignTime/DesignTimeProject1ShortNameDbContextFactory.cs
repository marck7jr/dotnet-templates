using Microsoft.EntityFrameworkCore.Design;

namespace Project1.Infrastructure.Persistence.DesignTime;
public class DesignTimeProject1ShortNameDbContextFactory : IDesignTimeDbContextFactory<Project1ShortNameDbContext>
{
    public Project1ShortNameDbContext CreateDbContext(string[] args)
    {
        throw new NotImplementedException();
    }
}