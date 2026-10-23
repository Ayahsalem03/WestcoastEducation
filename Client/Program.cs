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

 Teacher teacher = new()
{
    Förnamn = "Michael",
    Efternamn = "Andersson",
    Telefon = "0701234567",
    Personnummer = "198001011234",
    Address = "Storgatan 15",
    Postnummer = "41100",
    Ort = "Göteborg",
    Kunskapsområde= "Programmering"
};

Console.WriteLine(teacher);

EducationManager manager = new()
{
    Förnamn="Anna",
    Efternamn="Johanssom",
    Telefon="123456789",
    Address="srorgatan 2",
    Postnummer="12345",
    Ort="Göteborg",
    Kunskapsområde="IT",
    Anställningsdatum=new DateTime(2026,8,3)

};

Console.WriteLine(manager);