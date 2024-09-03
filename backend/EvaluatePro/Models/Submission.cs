public class Submission {
    public int Id { get; set; }
    public required int SubmitterId { get; set; }
    public required int ReceiverId { get; set; }
    public required int CategoryId{get;set;}
    public required int ScoreId {get;set;}
    public int? CommentId { get; set; }
    public required int RoleId { get; set; }
    public bool? IsDraft {get;set;}

    public required User User { get; set; }
    public required Role Role { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
    public List<Category> Categories { get; set; } = new List<Category>();
    public List<Score> Scores { get; set; } = new List<Score>();
    public required User Submitter { get; set; }
    public required User Receiver { get; set; }
}   