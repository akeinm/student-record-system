namespace StudentRecordSystem.Services;

public enum UserRole { Admin, Student }

public class CurrentUserService
{
    public UserRole Role { get; set; } = UserRole.Admin;
    public int? StudentId {get; set; }
}