using System.Runtime.Intrinsics.X86;

public class Role{
    public int Id{get;set;}
    public required String RoleId {get;set;}
    public int? IsAdmin {get;set;}
    public int? IsManager {get; set;}
    public int? IsEmpoyee { get; set; }

    public List<User> Users {get;set;} = new List<User>();
    public List<Submission> Submissions {get;set;} = new List<Submission>();
    }