namespace BlazorWebAssembly.Data;

public interface ICart
{
    IReadOnlyCollection<Product> GetProductsFromCart();
    Product GetProductFromCart(long id);
    void AddProductInCart(Product product);
    void ClearCart();
}