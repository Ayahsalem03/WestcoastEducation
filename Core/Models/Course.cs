namespace Core.Models;

public  class Course
{
    public int Kursnummer{get;set;}
    public string Title{get; set;}= "";

    public int Längd{get;set;}
    public DateTime StartDatum { get; set; }
    public DateTime EndDatum { get; set; }
    public string CourseType { get; set; } = "";


    public override string ToString()
{
    return $"Kursnummer: {Kursnummer}, Titel:{Title}, Längd: {Längd}veckor,Startdatum: {StartDatum:yyyy-MM-dd}, Slutdatum: {EndDatum:yyyy-MM-dd}, Kurstyp: {CourseType}";
}

}