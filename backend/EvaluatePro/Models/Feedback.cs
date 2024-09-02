public class Feedback{

    public int Id {get; set;}
    public required string FeedbackId {get;set;}
    public long Feedbacktext {get; set;}
    public int ConventionId {get;set;}
    public int ScoreId {get;set;}
    
    public required Convention Convention { get; set; }
    public required Score Score { get; set; }
    }