
using System.Text.Json.Serialization;

namespace Core.Models;

public class Student : Person
{
    [JsonPropertyName("_id")]
    public string? Id { get; set; }

    public override string ToString()
    {
        return $"Namn: {Förnamn} {Efternamn}, Telefon: {Telefon}, Personnummer: {Personnummer}, Adress: {Adress}";
    }
}

