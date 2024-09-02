public class Submission {
    public int Id { get; set; }
    public int SubmitterId { get; set; }
    public int ReceiverId { get; set; }
    public required string Category{get;set;}
    public string? Convention { get;set;}
    public required string Feedback{get;set;}
    public string? SubmissionComment { get; set; }
    public int RoleCheck { get; set; }
    public bool IsDraft {get;set;}

    public required Role Role { get; set; }
    public List<Score> Scores { get; set; } = new List<Score>();
}   