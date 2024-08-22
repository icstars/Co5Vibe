using Microsoft.EntityFrameworkCore;

public class EvaluateProDbContext : DbContext
{
    public DbSet<Employee> Employees { get;set; }

    public DbSet<Criteria> Criterias { get; set; }

    public EvaluateProDbContext(DbContextOptions<EvaluateProDbContext> options) : base(options){}
}