using System.Globalization;

namespace Core.Models;

public class Administrator : EducationManager
{
    public override string ToString()
    {
        return $"Adminstratör: {Förnamn} {Efternamn}, Kompetensområde: {Kunskapsområde}, Anställningsdatum: {Anställningsdatum}";
        
    }
}