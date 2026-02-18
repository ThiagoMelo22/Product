namespace Product.Models;

internal class PhysicalProduct : Product
{
    private int stock { get; set; }

    public PhysicalProduct(string name, string description, decimal price, string image) : base(name, description, price, image)
    {
        this.stock = 0;
    }

    public PhysicalProduct(string name, string description, decimal price, string image, int stock) : base(name, description, price, image)
    {
        this.stock = stock;
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

    public void GetPhyscalProduct(PhysicalProduct physcal) 
    {
        Console.WriteLine(@$"Dados do item 1: 
        Nome: {physcal.name};
        Descrição: {physcal.description};
        Preço: {physcal.price};
        Estoque: {physcal.stock};
        Nota: {physcal.Review.Rating};
        Comentário: {physcal.Review.Comment}");
    }

    public override void Deliver(string address)
    {
        Console.WriteLine($"Calculando frete com base no {address} e enviando {name}");
    }
}
