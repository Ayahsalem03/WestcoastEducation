namespace Core.Models;

public class EducationManager : Teacher
{
    public DateTime Anställningsdatum {get;set;}
    public override string ToString()
    {
        return $"Utbildningsledare: {Förnamn} {Efternamn}, Kompetenområde: {Kunskapsområde}, Anställningsdatum :{Anställningsdatum}";
    }
}