namespace Product.Models;

abstract class Product
{
    private string image;
    public string Name { get; }
    public string Description { get; }
    public decimal Price { get; private set; }
    public DateTime PurchaseDate { get; }
    public Review Review { get; private set; }

    public Product(string name, string description, decimal price, string image)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Image = image;
    }

    public void ChangePriceWithDiscount(decimal discount)
    {
        Price = Price * (1 - discount / 100);
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
