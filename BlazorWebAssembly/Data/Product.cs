namespace BlazorWebAssembly.Data;

public class Product
{
    public Product(long id, string name, decimal price, int amount, string imageSource, string description)
    {
        Id = id;
        Name = name;
        Price = price;
        Amount = amount;
        ImageSource = imageSource;
        Description = description;
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public string ImageSource { get; set; }
    public string Description { get; set; }
    
}