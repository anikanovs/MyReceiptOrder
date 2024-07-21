namespace API.Entities;

public class Person
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string Patronymic { get; set; } = string.Empty;
}