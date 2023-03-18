namespace PointBlank.Infrastructure.Database;

using Microsoft.EntityFrameworkCore;

public class MysqlContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(string.Empty);
    }
}