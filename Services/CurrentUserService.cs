namespace StudentRecordSystem.Services;

public enum UserRole { Admin, Student }

public class CurrentUserService
{
    private UserRole _role = UserRole.Admin;
    private int? _studentId;

    public UserRole Role
    {
        get => _role;
        set { _role = value; OnChange?.Invoke(); }
    }

    public int? StudentId
    {
        get => _studentId;
        set { _studentId = value; OnChange?.Invoke(); }
    }
    public event Action? OnChange;
}