using System.Runtime.Intrinsics.X86;

public class Role{
    public int Id{get;set;}
    public int RoleId {get;set;}
    public int UserId {get;set;}

    public List<Submission> Submissions {get;set;} = new List<Submission>();
    public User? Users { get; set; }
    }