using Microsoft.EntityFrameworkCore;

public class Day6Context(DbContextOptions<Day6Context> options) : DbContext(options)
{
    public DbSet<Day6.Models.Product> Product { get; set; } = default!;
}
