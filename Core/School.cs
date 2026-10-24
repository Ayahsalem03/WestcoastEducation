namespace Core.Models;

public class School
{
    public List<Course> Courses { get; set; } = new();
    public List<Student> Students { get; set; } = new();
    public List<Teacher> Teachers { get; set; } = new();
    public List<EducationManager> EducationManagers { get; set; } = new();

    public List<Administrator> Administrators { get; set; } = new();





    
}