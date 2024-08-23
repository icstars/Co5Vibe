public class Employee
{
    public int Id { get; set; } 

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Email { get; set; }

    public string? Title { get; set; }

    public bool? IsMAnager { get; set; }
    public List <Criteria>? Criteria { get; set; }
}