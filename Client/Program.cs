using Core.Models;

Course course= new()
{
    Kursnummer = 200,
    Title = "Programmering med CSharp",
    Längd = 12,
    StartDatum = new DateTime(2026, 8, 24),
    EndDatum = new DateTime(2027, 10, 31),
    CourseType = "Distans"

   
    
};
 Console.WriteLine(course);
