public class Score{

    public int Id {get; set;}
    public required int ScoreId { get; set; }
    public int SubmissionId {get; set;}
    public int CategoryId { get; set; }
    public int ConventionId { get; set; }
    
    public List<Submission> Submissions {get;set;} = new List<Submission>();
    public List<Category> Categories {get;set;} = new List<Category>();
    public List<Convention> Conventions {get;set;} = new List<Convention>();
    public List<Feedback> Feedbacks {get;set;} = new List<Feedback>();

    } 