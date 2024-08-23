using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EvaluateProDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))));
        //adding Cors
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:3000")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});
var app = builder.Build();
app.UseCors();

// Configure the HTTP request pipeline.
// Get all Emmployees
app.MapGet("/api/employees", async (EvaluateProDbContext db) => await db.Employees.Include(e => e.Criteria) .ToListAsync());
//Create Employee
app.MapPost("/api/employees", async (EvaluateProDbContext db, Employee employee) => {
    db.Employees.Add(employee);
    await db.SaveChangesAsync();
    return Results.Created($"/api/employees/{employee.Id}", employee);
});
app.MapGet("/api/criteria", async (EvaluateProDbContext db) => await db.Criterias.ToListAsync());

app.MapPost("/api/criteria", async (EvaluateProDbContext db, Criteria criteria) =>
{
    db.Criterias.Add(criteria);
    await db.SaveChangesAsync();
    return Results.Created($"/api/criteria/{criteria.Id}", criteria);
});

app.Run();