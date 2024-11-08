namespace AuthDatabase.Api.Models;

public class ItemEntity
{
    public ItemEntity(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}
