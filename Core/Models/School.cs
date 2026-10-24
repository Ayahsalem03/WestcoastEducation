namespace Core.Models;

public class School
{
    public List<Course> Courses { get; set; } = new();
    public List<Student> Students { get; set; } = new();
    public List<Teacher> Teachers { get; set; } = new();
    public List<EducationManager> EducationManagers { get; set; } = new();
    public List<Administrator> Administrators { get; set; } = new();
    public void AddStudent(Student student){
    if (!Students.Contains( student))
    {
        Students.Add(student);
    }
    }
    public void AddCourse(Course course)
    {
    if (!Courses.Contains(course))
    {
        Courses.Add(course);
    }
    }

    public void AddTeacher(Teacher teacher)
    {
    if (!Teachers.Contains(teacher))
    {
        Teachers.Add(teacher);
    }
}
public void AddEducationManager(EducationManager manager)
    {
    if (!EducationManagers.Contains(manager))
       {
        EducationManagers.Add(manager);
    }
    }

public void AddAdministrator(Administrator administrator)
{
    if (!Administrators.Contains(administrator))
    {
        Administrators.Add(administrator);
    }
}



}