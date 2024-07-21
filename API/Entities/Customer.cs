namespace API.Entities;

public class Customer : Person
{
    public required string Phone { get; set; }
    public string Passport { get; set; } = string.Empty;
}