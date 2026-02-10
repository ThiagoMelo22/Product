namespace Product.Models;

internal class PhysicalProduct : Product
{
    public int Stock { get; }

    public PhysicalProduct(string name, string description, decimal price, string image) : base(name, description, price, image)
    {
        this.Stock = 0;
    }

    public bool IsAvailable()
    {
        return Stock > 0;
    }
}
