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

// User: Get     
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
app.MapGet("/api/User/{id:int}/SupervisorName", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    return user is not null ? Results.Ok(user.SupervisorName) : Results.NotFound();
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



//User: Updates by specific id properites 
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
app.MapPut("/api/User/{id:int}/SupervisorName", async (EvaluateProDbContext db, int id, string? supervisorName) =>
{
    var user = await db.User.FindAsync(id);

    if (user is null) return Results.NotFound();

    user.SupervisorName = supervisorName;

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

//User: Delete 
app.MapDelete("/api/User/{id:int}", async (EvaluateProDbContext db, int id) =>
{
    var user = await db.User.FindAsync(id);
    
    if (user is null) return Results.NotFound();

    db.User.Remove(user);
    await db.SaveChangesAsync();
    return Results.NoContent();
});


// Submission: Create********************************************************************************************
// Create a new submission
app.MapPost("/api/Submission", async (EvaluateProDbContext db, Submission submission) =>
{
    db.Submission.Add(submission);
    await db.SaveChangesAsync();
    return Results.Created($"/api/User/{submission.Id}", submission);
});

// Submission: Get
// Read; get all sub'
app.MapGet("/api/Submission", async (EvaluateProDbContext db) => await db.Submission.ToListAsync(
));
// get all sub' by category
app.MapGet("/api/Submission/Category/{categoryId:int}", async (EvaluateProDbContext db, int categoryId) => 
{
    var submissions = await db.Submission
                              .Where(s => s.CategoryId == categoryId)
                              .ToListAsync();
    return submissions.Any() ? Results.Ok(submissions) : Results.NotFound();
});
// by Score
app.MapGet("/api/Submission/Score/{ScoreId:int}", async (EvaluateProDbContext db, int scoreId) => 
{
    var submissions = await db.Submission
                              .Where(s => s.ScoreId == scoreId)
                              .ToListAsync();
    return submissions.Any() ? Results.Ok(submissions) : Results.NotFound();
});
// by person proforming submission
app.MapGet("/api/Submission/BySubmitter/{SubmitterId:int}", async (EvaluateProDbContext db, int submitterId) => 
{
    var submissions = await db.Submission
                              .Where(s => s.SubmitterId == submitterId)
                              .ToListAsync();
    return submissions.Any() ? Results.Ok(submissions) : Results.NotFound();
});
// draft get by submitter
app.MapGet("/api/Submission/User/{SubmitterId:int}/Drafts", async (EvaluateProDbContext db, int submitterId) => 
{
    var submissions = await db.Submission
                              .Where(s => s.SubmitterId == submitterId && s.IsDraft == true)
                              .ToListAsync();
    return submissions.Any() ? Results.Ok(submissions) : Results.NotFound();
});

// by person reciving submission
app.MapGet("/api/Submission/ByReceiver/{ReceiverId:int}", async (EvaluateProDbContext db, int receiverId) => 
{
    var submissions = await db.Submission
                              .Where(s => s.ReceiverId == receiverId)
                              .ToListAsync();
    return submissions.Any() ? Results.Ok(submissions) : Results.NotFound();
});
// by Draft
app.MapGet("/api/Submission/User/{IsDraft:bool}", async (EvaluateProDbContext db, bool isDraft) => 
{
    var submissions = await db.Submission
                              .Where(s => s.IsDraft == isDraft)
                              .ToListAsync();
    return submissions.Any() ? Results.Ok(submissions) : Results.NotFound();
});

// Create Category****************************************************************************************
app.MapPost("/api/Category", async (EvaluateProDbContext db, Category category) =>
{
    db.Category.Add(category);
    await db.SaveChangesAsync();
    return Results.Created($"/api/User/{category.Id}", category);
});
// Retrieve all categories
app.MapGet("/api/Category", async (EvaluateProDbContext db) => 
{
    var categories = await db.Category.ToListAsync();
    return categories.Any() ? Results.Ok(categories) : Results.NotFound();
});

// Retrieve category by CategoryId
app.MapGet("/api/Category/{CategoryId:int}", async (EvaluateProDbContext db, int categoryId) => 
{
    var category = await db.Category
                           .Where(c => c.CategoryId == categoryId)
                           .FirstOrDefaultAsync();
    return category != null ? Results.Ok(category) : Results.NotFound();
});

// Conventions: Create********************************************************************************************
app.MapPost("/api/Convention", async (EvaluateProDbContext db, Convention convention) =>
{
    db.Convention.Add(convention);
    await db.SaveChangesAsync();
    return Results.Created($"/api/Convention/{convention.Id}", convention);
});
// get all conventions
app.MapGet("/api/Convention", async (EvaluateProDbContext db) =>
{
    var conventions = await db.Convention.ToListAsync();
    return Results.Ok(conventions);
});

 // to get a single convention
 app.MapGet("/api/Convention/{id:int}", async (EvaluateProDbContext db, int id) =>
{
    var convention = await db.Convention.FindAsync(id);
    return convention is not null ? Results.Ok(convention) : Results.NotFound();
});
//PUT,updates a single convention
app.MapPut("/api/Convention/{id:int}", async (EvaluateProDbContext db, int id, Convention updatedConvention) =>
{
    var convention = await db.Convention.FindAsync(id);

    if (convention is null) return Results.NotFound();

    // Update the properties of the found convention with the new values
    convention.CategoryId = updatedConvention.CategoryId;
    convention.ConventionId = updatedConvention.ConventionId;

    await db.SaveChangesAsync();
    return Results.Ok(convention);
});
//to update the score to a specific convention
app.MapPut("/api/Convention/{id:int}/Score", async (EvaluateProDbContext db, int id, int newScoreId) =>
{
    var convention = await db.Convention.FindAsync(id);

    if (convention is null) return Results.NotFound();

    convention.ScoreId = newScoreId;

    await db.SaveChangesAsync();
    return Results.Ok(convention);
});
//COMMMENTS**********************************************************************************
//get a certian comment by id
app.MapGet("/api/Comment/{id:int}", async (EvaluateProDbContext db, int id) => 
{
    var comment = await db.Comment.FindAsync(id);
    return comment is not null ? Results.Ok(comment) : Results.NotFound();
});

// will get comment from any of the 3 levels, submission,category,convention. 
app.MapGet("/api/Comment", async (EvaluateProDbContext db, int? submissionId, int? categoryId, int? conventionId) => 
{
    var query = db.Comment.AsQueryable();

    if (submissionId.HasValue)
        query = query.Where(c => c.SubmissionId == submissionId.Value);

    if (categoryId.HasValue)
        query = query.Where(c => c.CategoryId == categoryId.Value);

    if (conventionId.HasValue)
        query = query.Where(c => c.ConventionId == conventionId.Value);

    var comment = await query.FirstOrDefaultAsync();

    return comment is not null ? Results.Ok(comment) : Results.NotFound();
});
// Create any level  comments
app.MapPost("/api/Comment", async (EvaluateProDbContext db, int? submissionId, int? categoryId, int? conventionId, Comment newComment) =>
{
    if (submissionId.HasValue)
        newComment.SubmissionId = submissionId.Value;

    if (categoryId.HasValue)
        newComment.CategoryId = categoryId.Value;

    if (conventionId.HasValue)
        newComment.ConventionId = conventionId.Value;

    db.Comment.Add(newComment);
    await db.SaveChangesAsync();

    return Results.Created($"/api/Comment/{newComment.Id}", newComment);
});
//update any level comment
app.MapPut("/api/Comment", async (EvaluateProDbContext db, int? submissionId, int? categoryId, int? conventionId, Comment updatedComment) =>
{
    var query = db.Comment.AsQueryable();

    if (submissionId.HasValue)
        query = query.Where(c => c.SubmissionId == submissionId.Value);

    if (categoryId.HasValue)
        query = query.Where(c => c.CategoryId == categoryId.Value);

    if (conventionId.HasValue)
        query = query.Where(c => c.ConventionId == conventionId.Value);

    var comment = await query.FirstOrDefaultAsync();

    if (comment is null) return Results.NotFound();

    comment.Text = updatedComment.Text; 

    await db.SaveChangesAsync();
    return Results.Ok(comment);
});


//FEEDBACK************************************************************************************

//ROLE*****************************************************************************************

//SCORE****************************************************************************************

//AUTHENTICATION*******************************************************************************







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