namespace Core.Models;

public class Student: Person
{
    public override string ToString()
    {
        return $"Namn: {Förnamn} {Efternamn}, Telefon: {Telefon},Personnummer: {Personnummer},Address :{Adress} ";
    }
}


