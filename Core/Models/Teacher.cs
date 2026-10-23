namespace Core.Models;

public class Teacher : Person
{
    public string Kunskapsområde{get;set;}="";
    public List<Course> Courses{get; set; }= new();
    public void AddCourse(Course course)
{
    if (!Courses.Contains(course))
    {
        Courses.Add(course);
    }
}
        public override string ToString()
    {
        return $"Lärare: {Förnamn} {Efternamn}, Kompetensområde: {Kunskapsområde}";
    }
}