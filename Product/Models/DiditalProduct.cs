using Product.Interfaces;

namespace Product.Models;

internal class DiditalProduct : Product, IExpired
{
    private string linkDownload;
    public int Stock { get; }

    public DiditalProduct(string name, string description, decimal price, string image, string linkDownload) : base(name, description, price, image)
    {
        this.LinkDownload = linkDownload;
    }

    public bool IsAvailable()
    {
        return Stock > 0;
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
}
