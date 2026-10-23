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

 Student student= new()
 {
     Förnamn= "Ayah",
     Efternamn="Salem",
     Telefon="07222222222",
     Personnummer="200306299999",
     Address="Hjortmossegatan 16",
     Postnummer="46151",
     Ort="Trollhättan"

 };

 Console.WriteLine(student);
