using System.Runtime.Intrinsics.X86;

public class Role
{
    public int Id{get;set;}
    public required String RoleId {get;set;}
    public int UserId { get; set; }

    public List<Submission> Submissions {get;set;} = new List<Submission>();
    public List<User> Users { get; set; } = new List<User>(); 
}