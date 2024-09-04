using System;

public class User
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime BirthDay {get; set;}
    public required string Email { get; set;}
    public required string Title { get; set;}
    public required int RoleId { get; set;} 
    public string? SupervisorName {get; set;}
    public required bool IsActive { get; set;}
    public char Password {get;set;}
    public required Role Role { get; set; }
    public Authentication? Authentication { get; set; }
    public List<Submission> Submissions { get; set; } = new List<Submission>();
 }