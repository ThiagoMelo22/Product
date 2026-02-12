namespace Product.Models;

internal class PhysicalProduct : Product
{
    private int stock { get; set; }

    public PhysicalProduct(string name, string description, decimal price, string image) : base(name, description, price, image)
    {
        this.stock = 0;
    }

    public bool IsAvailable()
    {
        return stock > 0;
    }

    public void CreatedPhyscalProduct(int stock) 
    {
        base.ProductNote(10, "Excelente!");
        this.stock = stock;
    }

    public void ShowPhyscalProduct(PhysicalProduct physcal) 
    {
        Console.WriteLine(@$"Dados do item 1: 
        Nome: {physcal.name};
        Descrição: {physcal.description};
        Preço: {physcal.price};
        Estoque: {physcal.stock};
        Nota: {physcal.Review.Rating};
        Comentário: {physcal.Review.Comment}");
    }
}
