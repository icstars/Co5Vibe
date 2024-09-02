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
// Users: Create********************************************************************************************
// Create a new user
app.MapPost("/api/User", async (EvaluateProDbContext db, User user) =>
{
    db.User.Add(user);
    await db.SaveChangesAsync();
    return Results.Created($"/api/User/{user.Id}", user);
});

// User: Get     *************************************************************************************************
// Read; get all
app.MapGet("/api/User", async (EvaluateProDbContext db) => await db.User.ToListAsync());

//Get Specific UserId and/or its properties
app.MapGet("/api/User/{id:int}", async (EvaluateProDbContext db, int id) => 
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user) : Results.NotFound();
});

app.MapGet("/api/User/{id:int}/FirstName", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.FirstName) : Results.NotFound();
});

app.MapGet("/api/User/{id:int}/LastName", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.LastName) : Results.NotFound();
});
app.MapGet("/api/User/{id:int}/BirthDay", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.BirthDay) : Results.NotFound();
});
app.MapGet("/api/User/{id:int}/Email", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.Email) : Results.NotFound();
});
app.MapGet("/api/User/{id:int}/Title", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.Title) : Results.NotFound();
});
app.MapGet("/api/User/{id:int}/RoleId", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.RoleId) : Results.NotFound();
});
app.MapGet("/api/User/{id:int}/SupervisiorName", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.SupervisiorName) : Results.NotFound();
});
app.MapGet("/api/User/{id:int}/IsActive", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.IsActive) : Results.NotFound();
});
app.MapGet("/api/User/{id:int}/Password", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.Password) : Results.NotFound();
});



//User: Updates by specific id properites *******************************************************************************
app.MapPut("/api/User/{id:int}/FirstName", async (EvaluateProDbContext db, int id, string FirstName) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.FirstName = FirstName;
   
    await db.SaveChangesAsync();
    return Results.Ok(user);
});

app.MapPut("/api/User/{id:int}/LastName", async (EvaluateProDbContext db, int id, string lastName) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.LastName = lastName;

    await db.SaveChangesAsync();
    return Results.Ok(user);
});

app.MapPut("/api/User/{id:int}/BirthDay", async (EvaluateProDbContext db, int id, DateTime birthDay) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.BirthDay = birthDay;

    await db.SaveChangesAsync();
    return Results.Ok(user);
});
app.MapPut("/api/User/{id:int}/Email", async (EvaluateProDbContext db, int id, string email) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.Email = email;

    await db.SaveChangesAsync();
    return Results.Ok(user);
});
app.MapPut("/api/User/{id:int}/Title", async (EvaluateProDbContext db, int id, string title) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.Title = title;

    await db.SaveChangesAsync();
    return Results.Ok(user);
});
app.MapPut("/api/User/{id:int}/RoleId", async (EvaluateProDbContext db, int id, int roleId) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.RoleId = roleId;

    await db.SaveChangesAsync();
    return Results.Ok(user);
});
app.MapPut("/api/User/{id:int}/SupervisiorName", async (EvaluateProDbContext db, int id, string? supervisiorName) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.SupervisiorName = supervisiorName;

    await db.SaveChangesAsync();
    return Results.Ok(user);
});
app.MapPut("/api/User/{id:int}/IsActive", async (EvaluateProDbContext db, int id, bool isActive) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.IsActive = isActive;

    await db.SaveChangesAsync();
    return Results.Ok(user);
});
app.MapPut("/api/User/{id:int}/Password", async (EvaluateProDbContext db, int id, char password) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.Password = password;

    await db.SaveChangesAsync();
    return Results.Ok(user);
});

//User: Delete *************************************************************************************************
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