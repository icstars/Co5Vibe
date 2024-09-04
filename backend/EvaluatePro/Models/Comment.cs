public class Comment {
    public int Id {get; set;}
    public int CategoryId {get; set;}
    public int ConventionId {get; set;}
    public int SubmissionId {get; set;}
    public int UserId { get;set;}
    public bool CommentType {get; set;}
    public string? Text {get; set;}
    public Submission? Submission { get; set; }
    public Category? Category { get; set; }
    public Convention? Convention { get; set; }
}