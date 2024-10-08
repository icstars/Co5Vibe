public class Convention{
    public int Id {get; set;}
    public required int ConventionId {get; set;}
    public int CategoryId{get;set;}
    public int FeedbackId { get; set; }
    public int ScoreId { get; set; }
    public int CommentID { get; set; }

    public required Category Category { get; set; }
    public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    public required Score  Score { get; set; }
    public Comment? Comment { get; set; }


}
