namespace Core.Models;

public class Address
{
    public string Street { get; set; } = "";
    public string Postnummer { get; set; } = "";
    public string Ort { get; set; } = "";

    public override string ToString()
    {
        return $"{Street}, {Postnummer}, {Ort}";
    }
}