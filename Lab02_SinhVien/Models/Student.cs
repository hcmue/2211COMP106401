namespace Lab02_SinhVien.Models;

public class Student
{
    public string StudentId { get; set; }
    public string FullName { get; set; }
    public double Grade { get; set; }
    public string Rank
    {
        get
        {
            if (Grade >= 8.5) return "A";
            if (Grade >= 7.8) return "B";
            if (Grade >= 5) return "C";
            return "D";
        }
    }
}