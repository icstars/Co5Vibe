public class Comment {
    public int Id {get; set;}
    public int UserId { get;set;}
    public bool CommentType {get; set;}

    public Submission? Submission { get; set; }
    public Category? Category { get; set; }
    public Convention? Convention { get; set; }
}