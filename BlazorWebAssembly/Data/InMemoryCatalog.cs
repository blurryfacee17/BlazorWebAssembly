using System.Collections.Concurrent;

namespace BlazorWebAssembly.Data;

public class InMemoryCatalog : ICatalog
{
    private readonly ConcurrentBag<Product> _products = new()
    {
        new(1, "Молоко", 50m, 5,
            "https://www.hysterectomy.org/wp-content/uploads/shutterstock_568076731.jpg",
            "100% натуральное молоко. Без добавления консервантов и красителей. Жирность 3, 2 % подходит для тех, кто любит традиционный вкус молока. Пить молоко «Домик в деревне» можно холодным и тёплым. Идеально для кофе, чая и приготовления ваших любимых блюд"),
        new(2, "Хлеб", 30m, 10,
            "https://media.baamboozle.com/uploads/images/306786/1659329828_417612_url.jpeg",
            "Срок годности в днях: 90 Состав: Мука пшеничная хлебопекарная высший сорт, вода, сахар, масло растительное, улучшитель хлебопекарный эмульгатор моно- и диглицериды жирных кислот, консервант – пропионат кальция, мука пшеничная хлебопекарная, мука соевая, ферменты, антиокислитель – кислота аскорбиновая, спирт пищевой, соль, клейковина пшеничная сухая, дрожжи. Страна изготовления: Россия"),
        new(3, "Шоколад", 60m, 3,
            "https://mykaleidoscope.ru/uploads/posts/2021-09/1632766939_41-mykaleidoscope-ru-p-shokolad-na-belom-fone-krasivo-foto-42.jpg",
            "Шоколад молочный с альпийским молоком 100 г — это нежнейший шоколад высокого качества, созданный из натуральных ингредиентов опытными немецкими кондитерами. Благодаря долгому процессу конширования шоколадная масса из альпийского молока и отборных какао-продуктов обретает особый карамельно-медовый аромат.")
    };

    public IReadOnlyList<Product> GetProducts() => _products.ToList();

    public Product GetProduct(long id) => _products.First(it => it.Id == id);

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void ClearCatalog()
    {
        _products.Clear();
    }
}