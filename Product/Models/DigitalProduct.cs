using Product.Interfaces;

namespace Product.Models;

internal class DigitalProduct : Product, IExpired
{
    private string linkDownload;
    private int stock { get; set; }

    public DigitalProduct(string name, string description, decimal price, string image, string linkDownload) : base(name, description, price, image)
    {
        this.LinkDownload = linkDownload;
    }

    public bool IsAvailable()
    {
        return stock > 0;
    }

    public string LinkDownload
    {
        get
        {
            return linkDownload;
        }
        set
        {
            if (value.Length > 0)
            {
                this.linkDownload = value;
            }
        }
    }

    public bool IsExpired()
    {
        return DateTime.Now > PurchaseDate.AddYears(15);
    }

    public void CreatedDigitalProduct(int stock)
    {
        base.ProductNote(10, "Excelente!");
        this.stock = stock;
    }

    public void GetDigitalProduct(DigitalProduct digital)
    {
        Console.WriteLine(@$"Dados do item 1: 
        Nome: {digital.name};
        Descrição: {digital.description};
        Preço: {digital.price};
        Estoque: {digital.stock};
        Link: {digital.LinkDownload};
        Nota: {digital.Review.Rating};
        Comentário: {digital.Review.Comment};
        Está expirado: {digital.IsExpired()}");
    }

    public override void Deliver(string address)
    {
        Console.WriteLine($"Enviando {name} para o e-mail {address}");
    }
}
