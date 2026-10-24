using Core.Models;

Course course= new()
{
    Kursnummer = 200,
    Title = "Programmering med CSharp",
    Längd = 12,
    StartDatum = new DateTime(2026, 8, 24),
    EndDatum = new DateTime(2026, 11, 16),
   
    CourseType = "Distans"

   
    
};
if (course.CheckDates())
{
    Console.WriteLine("Kursens datum är giltiga.");

}
else
{
    Console.WriteLine("Kursens datum är ogiltiga.");
}

 

 Student student= new()
 {
     Förnamn= "Ayah",
     Efternamn="Salem",
     Telefon="07222222222",
     Personnummer="200306299999",
 

 };
student.Adress.Street = "Hjortmossegatan 16";
student.Adress.Postnummer = "46151";
student.Adress.Ort= "Trollhättan";

 
 School school= new();
school.AddStudent(student);
foreach (Student s in school.Students)
{
    Console.WriteLine(s);
}
school.AddCourse(course);



 Teacher teacher = new()
{
    Förnamn = "Michael",
    Efternamn = "Andersson",
    Telefon = "0701234567",
    Personnummer = "198001011234",

    Kunskapsområde= "Programmering"
};
teacher.Adress.Street = "Storgatan 15";
teacher.Adress.Postnummer = "41100";
teacher.Adress.Ort = "Göteborg";

teacher.AddCourse(course);
school.AddTeacher(teacher);

foreach (Teacher t in school.Teachers)
{
    Console.WriteLine(t);
}


foreach(Course c in school.Courses)
{
    Console.WriteLine(c);
}

EducationManager manager = new()
{
    Förnamn = "Anna",
    Efternamn = "Johanssom",
    Telefon = "123456789",
    Kunskapsområde = "IT",
    Anställningsdatum = new DateTime(2026, 8, 3)
};

manager.Adress.Street = "Storgatan 2";
manager.Adress.Postnummer = "12345";
manager.Adress.Ort = "Göteborg";






Administrator administrator = new()
{
    Förnamn = "Fredrek",
    Efternamn = "Johansson",
    Telefon = "987654321",
    Kunskapsområde = "Administration",
    Anställningsdatum = new DateTime(2022, 8, 3)
};

administrator.Adress.Street = "Storgatan 3";
administrator.Adress.Postnummer = "44567";
administrator.Adress.Ort = "Göteborg";



school.AddEducationManager(manager);

foreach (EducationManager m in school.EducationManagers)
{
    Console.WriteLine(m);
}

school.AddAdministrator(administrator);

foreach (Administrator a in school.Administrators)
{
    Console.WriteLine(a);
}