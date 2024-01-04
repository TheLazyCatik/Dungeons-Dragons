using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{
    public DbSet<Unit> Unit { get; set; }
    public DbSet<Equipment> Equipment { get; set; }
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    {
       
    }
}

