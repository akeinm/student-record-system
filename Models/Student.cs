namespace StudentRecordSystem.Models;

public class Student

{
    public int Id { get; set; }
    public string StudentNumber { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
    public string AcademicStatus { get; set; } = "Active";
    public int CourseId { get; set; }

    public Course? Course { get; set; }
    public List<Enrollment> Enrollments { get; set; } = new();
}