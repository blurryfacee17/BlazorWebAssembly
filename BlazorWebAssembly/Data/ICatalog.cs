namespace BlazorWebAssembly.Data;


public interface ICatalog
{
    IReadOnlyList<Product> GetProducts();
    Product GetProduct(long id);
    void AddProduct(Product product);
    void ClearCatalog();
}