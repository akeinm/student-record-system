using StudentRecordSystem.Models;

namespace StudentRecordSystem.Services;

public static class WamCalculator

{
    public static double CalculateWam(Student student)
    {
        var completed = student.Enrollments
            .Where(e => e.Mark.HasValue && e.Unit != null)
            .ToList();

        if (!completed.Any()) return 0;

        double totalWeighted = completed.Sum( e => e.Mark!.Value * e.Unit!.CreditPoints);
        int totalCredits = completed.Sum( e => e.Unit!.CreditPoints);

        return totalCredits == 0 ? 0 : Math.Round(totalWeighted / totalCredits, 2);

    }
}