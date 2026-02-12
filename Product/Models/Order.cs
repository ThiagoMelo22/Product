using Product.Interfaces;

namespace Product.Models;

internal class Order : IExpired
{
    private bool paid;
    public int Id { get; }
    public string Client { get; }
    public DateTime Date { get; }
    public decimal TotalValue { get; }

    public Order(int id, string client, decimal totalValue) 
    {
        Id = id;
        Client = client;
        Date = DateTime.Now;
        TotalValue = totalValue;
        paid = false;
    }

    public void ShowResum() 
    {
        Console.WriteLine($"Pedido #{Id} - Cliente: {Client}");
        Console.WriteLine($"Valor Total: R$ {TotalValue:F2}");
        Console.WriteLine($"Status: {(IsExpired() ? "Expirado" : "Válido")}");
    }

    public bool IsExpired() 
    {
        return !paid && DateTime.Now > Date.AddMinutes(15);
    }

    public void Pay() 
    {
        paid = true;
    }
}
