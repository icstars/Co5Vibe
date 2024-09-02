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

// CRUD operations
// Users: Create
// Create a new user
app.MapPost("/api/User", async (EvaluateProDbContext db, User user) =>
{
    db.User.Add(user);
    await db.SaveChangesAsync();
    return Results.Created($"/api/User/{user.Id}", user);
});

// User: Read
// Read; get all
app.MapGet("/api/User", async (EvaluateProDbContext db) => await db.User.ToListAsync());

//Get Specific UserId
app.MapGet("/api/User/{id:int}", async (EvaluateProDbContext db, int id) => 
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user) : Results.NotFound();
});

//User: Update
app.MapPut("/api/User/{id:int}", async (EvaluateProDbContext db, int id, User updatedUser) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.FirstName = updatedUser.FirstName;
    user.LastName = updatedUser.LastName;
    user.Email = updatedUser.Email;
    user.Title = updatedUser.Title;
    user.RoleId = updatedUser.RoleId;
    user.SupervisiorName = updatedUser.SupervisiorName;
    user.IsActive = updatedUser.IsActive;
    user.BirthDay = updatedUser.BirthDay;

    await db.SaveChangesAsync();
    return Results.Ok(user);
});

//User: Delete 
app.MapDelete("/api/User/{id:int}", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    
    if (user is null) return Results.NotFound();

    db.User.Remove(user);
    await db.SaveChangesAsync();
    return Results.NoContent();
});




/*
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
*/
app.Run();