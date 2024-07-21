namespace API.Entities;

public class Receipt
{
    public int Id { get; set; }
    public int Task { get; set; }
    public virtual required Customer Customer { get; set; } 
    public virtual required OrderPoint OrderPoint { get; set; }
    public virtual required AppUser AppUser { get; set; }
    public virtual required Order Order { get; set; }
    public double Price { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateDone { get; set; }
}
