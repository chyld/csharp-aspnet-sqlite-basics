using Microsoft.EntityFrameworkCore;

namespace web
{
  public class Database : DbContext
  {
    public DbSet<Dog> Dogs { get; set; }
    public Database(DbContextOptions<Database> options) : base(options) { }
  }
}
