namespace API.Entities;

public class Order
{
    public int Id { get; set; } 
    public int Number { get; set; }
    public virtual required DoingPoint DoingPoint { get; set; }

}
