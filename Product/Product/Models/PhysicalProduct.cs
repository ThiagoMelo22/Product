namespace Product.Models;

internal class PhysicalProduct : Product
{
    public int Stock { get; }

    //public PhysicalProduct(string name, string description, decimal price, string image) 
    //{ 
    //    this.Name = name;
    //    this.Description = description;
    //    this.Price = price;
    //    this.Stock = 0;
    //    this.Image = image;
    //}

    public bool IsAvailable()
    {
        return Stock > 0;
    }
}
