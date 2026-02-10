namespace Product.Models;

internal class DiditalProduct : Product
{
    private string linkDownload;
    public int Stock { get; }

    //public DiditalProduct(string name, string description, decimal price, string image) 
    //{ 
    //    this.Name = name;
    //    this.Description = description;
    //    this.Price = price;
    //    this.Stock = 0;
    //    this.Image = image;
    //    this.LinkDownload = linkDownload;
    //}

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
}
