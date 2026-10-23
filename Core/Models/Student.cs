namespace Core.Models;

public class Student
{
    public string Förnamn {get;set;}="";
    public string Efternamn {get;set;}="";
    public string Telefon{get; set;}="";
    public string Personnummer{get;set;}="";
    public string Address{get;set;}="";
    public string Postnummer{get;set;}="";
    public string Ort{get;set;}="";

    public override string ToString()
    {
        return $"Namn: {Förnamn} {Efternamn}, Telefon: {Telefon},Personnummer: {Personnummer},Address :{Address},Postnummer: {Postnummer},Ort: {Ort} ";
    }
}


