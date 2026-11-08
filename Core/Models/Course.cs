namespace Core.Models;

public  class Course
{
    [System.Text.Json.Serialization.JsonPropertyName("_id")]
    public string? Id { get; set; } 
    public int Kursnummer{get;set;}
    public string Title{get; set;}= "";

    public int Längd{get;set;}
    public DateTime StartDatum { get; set; }
    public DateTime EndDatum { get; set; }
    public string CourseType { get; set; } = "";

    public bool CheckDates()
    {
        if (EndDatum > StartDatum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
    return $"Kursnummer: {Kursnummer}, Titel:{Title}, Längd: {Längd}veckor,Startdatum: {StartDatum:yyyy-MM-dd}, Slutdatum: {EndDatum:yyyy-MM-dd}, Kurstyp: {CourseType}";
    }

}