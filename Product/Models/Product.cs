namespace Product.Models;

public class Product
{
    private string image;
    public string name { get; private set; }
    public string description { get; private set; }
    public decimal price { get; private set; }
    public DateTime PurchaseDate { get; }
    public Review Review { get; private set; }

    public Product(string name, string description, decimal price, string image)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.Image = image;
    }

    public void ChangePriceWithDiscount(decimal discount)
    {
        price = price * (1 - discount / 100);
    }

    public string Image
    {
        get
        {
            return image;
        }
        set
        {
            if (value.Length > 0)
            {
                this.image = value;
            }
        }
    }

    public void ProductNote(int rating, string comment) 
    {
        Review = new Review(rating, comment);
    }
}
