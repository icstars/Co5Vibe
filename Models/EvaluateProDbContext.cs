using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

public class EvaluateProDbContext(DbContextOptions<EvaluateProDbContext> options) : DbContext(options)
{
    public DbSet<User> User { get;set; }
    
    public DbSet<Convention> Convention { get; set; }
    
    public DbSet<Category> Category {get;set;}
   
    public DbSet<Score> Score {get;set;}
    
    public DbSet<Submission> Submission {get;set;}

    public DbSet <Authentication> Authentication {get;set;}
    
    public DbSet <Feedback> Feedback {get; set;}

    public Dbset <Comment> Comment {get; set;}

    public Dbset <Draft> Draft {get; set;}

}


