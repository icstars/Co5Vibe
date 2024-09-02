using System;

public class User
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime BirthDay {get; set;}
    public required string Email { get; set;}
    public required string Title { get; set;}
    public required int RoleId { get; set;} 
    public string? SupervisiorName {get; set;}
    public required bool IsActive { get; set;}
    public char Password {get;set;}

    public Authentication? Authentication { get; set; }
    public Role? Role { get; set; }
    public List<Submission> Submissions { get; set; } = new List<Submission>();

   }