namespace API.Entities;

public class Customer
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string Patronymic { get; set; } = string.Empty;
    public required string Phone { get; set; }
    public string Passport { get; set; } = string.Empty;
}