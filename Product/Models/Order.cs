using Product.Interfaces;

namespace Product.Models;

internal class Order : IExpired
{
    private bool paid;
    public int Id { get; }
    public string Client { get; }
    public DateTime Date { get; }
    public decimal TotalValue { get; }
    public Review Review { get; }
    public List<Product> Products { get; private set; }

    public Order(int id, string client, decimal totalValue) 
    {
        Id = id;
        Client = client;
        Date = DateTime.Now;
        TotalValue = totalValue;
        Products = new List<Product>();
        paid = false;
    }

    public void ShowResum() 
    {
        Console.WriteLine($"Pedido #{Id} - Cliente: {Client}");
        Console.WriteLine($"Valor Total: R$ {TotalValue:F2}");
        Console.WriteLine($"Status: {(IsExpired() ? "Expirado" : "Válido")}");

        Console.WriteLine("Produtos do pedido: ");
        foreach (var produc in Products) 
        {
            Console.WriteLine(produc.name);
        }
    }

    public bool IsExpired() 
    {
        return !paid && DateTime.Now > Date.AddMinutes(15);
    }

    public void Pay() 
    {
        paid = true;
    }

    public void AddProduct(Product product) 
    {
        Products.Add(product);
    }

    public void GetOrder(Order order) 
    {
        order = new Order(1, "Teste", 100.00m);

    }
}
