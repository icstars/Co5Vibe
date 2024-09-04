public class Category
{   public int Id {get;set;}
    public int CategoryId { get; set; }
    public required int ConventionId{get;set;}
    public int SubmissionId {get;set;}
    public int ScoreId {get;set;}
    public int CommentId { get; set; }
    public int User { get; set; }

    public List<User> Users {get;set;} = new List<User>();
    public required Score Score {get;set;}
    public Comment? Comment {get;set;}
    public required Submission Submission { get; set; }
    public List<Convention> Conventions {get;set;} = new List<Convention>();}
