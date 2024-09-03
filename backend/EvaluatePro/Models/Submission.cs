public class Submission {
    public int Id { get; set; }
    public int SubmitterId { get; set; }
    public int ReceiverId { get; set; }
    public required string Category{get;set;}
    public int ScoreId {get;set;}
    public int SubmissionComment { get; set; }
    public int RoleCheck { get; set; }
    public bool? IsDraft {get;set;}
    public int CategoryId { get; set; }


    public required User User { get; set; }
    public required Role Role { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
    public List<Category> Categories { get; set; } = new List<Category>();
    public List<Score> Scores { get; set; } = new List<Score>();
}   