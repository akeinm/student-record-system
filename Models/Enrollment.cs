namespace StudentRecordSystem.Models;

public class Enrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int UnitId { get; set; }
    public string Semester { get; set; } = "";
    public int? Mark { get; set; }
    public string Grade { get; set; } = "";

    public Student? Student { get; set; }
    public Unit? Unit { get; set; } 

}
