namespace Product.Models;

internal class Product
{
    private string image;
    public string Name { get; }
    public string Description { get; }
    public decimal Price { get; private set; }

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
}
