using System;

public class User
{
     public int Id { get; set; }

    public string FirstName { get; set; }

    public required string LastName { get; set; }

     public DateTime BirthDay {get; set;
}
    public string Email { get; set; }

     public string Title { get; set; }

    public string Rank { get; set; }

    public bool IsManager { get; set; }
    
    public string SupervisorName {get; set;}

    public bool IsActive { get; set;}

    public string? LinkedIn {get; set;}

    public char Password {get;set;}
   }