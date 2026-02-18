namespace Product.Models;

internal class Database
{
    List<Product> products = new List<Product>()
    {
        new DigitalProduct("Curso", "OO em C#", 100.00m, "Imagem ilustrativa", "Link"),
        new PhysicalProduct("Teclado", "Modelo compacto e silencioso, perfeito para produtividade diária", 80.00m, "Imagem")
    };

    public Product GetProducByName(string name) 
    {
        foreach (var product in products) 
        {
            if (product.name.Equals(name)) 
            {
                return product;
            }
        }
        return null;
    }
}
