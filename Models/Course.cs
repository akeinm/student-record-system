namespace StudentRecordSystem.Models;

public class Course
{
    public int Id { get; set; }
    public string CourseCode { get; set; } = "";
    public string Name { get; set; } = "";
    public int TotalCreditPoints { get; set; }

    public List<Student> Students { get; set; } = new();

}

