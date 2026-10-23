namespace Core.Models;

public class Person
{
    public string Förnamn { get; set; } = "";
    public string Efternamn { get; set; } = "";
    public string Telefon { get; set; } = "";
    public string Personnummer { get; set; } = "";

    public Address Adress { get; } = new();
}