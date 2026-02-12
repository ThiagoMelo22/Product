using Product.Models;


PhysicalProduct item1 = new PhysicalProduct("Teclado", "Modelo compacto e silencioso, " +
    "perfeito para produtividade diária. ", 80.00m, "Imagem");
item1.CreatedPhyscalProduct(10);

Console.WriteLine($"Imagem: {item1.Image}");
item1.Image = "Nova Imagem";
Console.WriteLine($"Imagem: {item1.Image}");

DiditalProduct item2 = new DiditalProduct("Curso", "OO em C#", 100.00m, "Imagem ilustrativa", "Link");
item2.CreatedDigitalProduct(15);

item1.ShowPhyscalProduct(item1);

Console.WriteLine("------------------------------");

item2.ShowDigitalProduct(item2);

Console.WriteLine("------------------------------");
Order order = new Order(1, "Teste", 100.00m);
order.ShowResum();