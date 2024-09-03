public class Comment {
    public int Id {get;set;}
    public int UserId {get;set;}
    public int SubmissionId {get;set;}
    public int CategoryId {get;set;}
    public int ConventionId {get;set;}
    public bool CommentType {get; set;}
    public long Text {get;set;}

   /* public Submission? Submission {get;set;}
    public Category? Category {get;set;}
    public Convention? Convention {get;set;}*/

    public List<Category> Categories { get; set; }= new List<Category>();
     public List<Submission> Submissions { get; set; }= new List<Submission>(); 
    public List<Convention> Conventions {get;set;} = new List<Convention>();
}