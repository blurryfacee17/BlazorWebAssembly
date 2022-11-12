namespace BlazorWebAssembly.Data;

public class InMemoryCart : ICart
{
    private readonly List<Product> _products = new();

    public IReadOnlyCollection<Product> GetProductsFromCart() => _products;

    public Product GetProductFromCart(long id) => _products.First(it => it.Id == id);

    public void AddProductInCart(Product product)
    {
        _products.Add(product);
    }

    public void ClearCart()
    {
        _products.Clear();
    }
}