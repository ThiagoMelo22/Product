using Product.Interfaces;

namespace Product.Models;

internal class DiditalProduct : Product, IExpired
{
    private string linkDownload;
    private int stock { get; set; }

    public DiditalProduct(string name, string description, decimal price, string image, string linkDownload) : base(name, description, price, image)
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

    public void ShowDigitalProduct(DiditalProduct digital)
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
}
