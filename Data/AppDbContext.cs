using Microsoft.EntityFrameworkCore;
using StudentRecordSystem.Models;

namespace StudentRecordSystem.Data;

public class AppDbContext : DbContext

{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Unit> Units => Set<Unit>();
    public DbSet<Enrollment> Enrollments => Set<Enrollment>();

    protected override void onModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>().HasData(
            new Course { Id = 1, CourseCode = "BSC-CS", Name = "Bachelor of Computer Science", TotalCreditPoints = 300 }
        );

        modelBuilder.Entity<Unit>().HasData(
            new Unit { Id = 1, UnitCode = "CSP1150", Name = "Programming Principles", CreditPoints = 15},
            new Unit { Id = 2, UnitCode = "CSP2131", Name = "Data Structures", CreditPoints = 15},
            new Unit { Id = 3, UnitCode = "CSP3341", Name = "Programming Languages and Paradigms", CreditPoints = 15}
        );

        modelBuilder.Entity<Student>().HasData(
            new Student { Id = 1, StudentNumber = "10906798", FullName = "Mike John", Email = "mikejohn@gmail", AcademicStatus = "Active", CourseId = 1},
            new Student { Id = 2, StudentNumber = "10745913", FullName = "John Bradley", Email = "johnbradley@gmail", AcademicStatus = "Active", CourseId = 1}
        );

        modelBuilder.Entity<Enrollment>().HasData(
            new Enrollment { Id = 1, StudentId = 1, UnitId = 1, Semester = "2025-S1", Mark = 78, Grade = "D" },
            new Enrollment { Id = 2, StudentId = 1, UnitId = 2, Semester = "2025-S2", Mark = 68, Grade = "C" },
            new Enrollment { Id = 3, StudentId = 1, UnitId = 3, Semester = "2026-S1", Mark = null, Grade = "" },
            new Enrollment { Id = 4, StudentId = 2, UnitId = 1, Semester = "2025-S1", Mark = 93, Grade = "HD" }
        );
    }
}

