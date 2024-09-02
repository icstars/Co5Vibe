public class Convention{
    public int id {get; set;}
    public required string ConventionId {get; set;}
    public int CategoryId{get;set;}
    public int FeedbackId { get; set; }
    public int ScoreId { get; set; }
    public int CommentID { get; set; }

    public required Category Category { get; set; }
    public required Feedback Feedback { get; set; }
    public required Score  Score { get; set; }
    public Comment? Comment { get; set; }


}
