using Product.Models;


PhysicalProduct item1 = new PhysicalProduct("Teclado", "Modelo compacto e silencioso, " +
    "perfeito para produtividade diária. ", 80.00m, "Imagem");
item1.CreatedPhyscalProduct(10);

Console.WriteLine($"Imagem: {item1.Image}");
item1.Image = "Nova Imagem";
Console.WriteLine($"Imagem: {item1.Image}");

DigitalProduct item2 = new DigitalProduct("Curso", "OO em C#", 100.00m, "Imagem ilustrativa", "Link");
item2.CreatedDigitalProduct(15);

item1.GetPhyscalProduct(item1);

Console.WriteLine("------------------------------");

item2.GetDigitalProduct(item2);

Console.WriteLine("------------------------------");
Order order = new Order(1, "Teste", 100.00m);
order.GetOrder(order);
order.AddProduct(item1);
order.AddProduct(item2);

order.ShowResum();
Console.WriteLine("------------------------------");

Database data = new Database();
var product = (PhysicalProduct)data.GetProducByName("Teclado");
item1.GetPhyscalProduct(product);