public class Submission {
    public int Id { get; set; }
    public int SubmitterId { get; set; }
    public int ReceiverId { get; set; }
    public List<Score> Scores { get; set; } = new List<Score>();
    public string Category{get;set;}
    public string? Convention { get;set;}
    public string Feedback{get;set;}
    public string? SubmissionComment { get; set; }
    public bool IsDraft {get;set;}
}   