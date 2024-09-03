public class Category
{   public int Id {get;set;}
    public required string ConventionId{get;set;}
    public int SubmissionId {get;set;}
    public int ScoreId {get;set;}
    public int CommentId { get; set; }

    public required User User { get; set; }
    public required Score Score {get;set;}
    public Comment? Comment {get;set;}
    public required Submission Submission { get; set; }
    public List<Convention> Conventions {get;set;} = new List<Convention>();
    }
