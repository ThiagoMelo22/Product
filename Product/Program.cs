using Product.Models;

PhysicalProduct item1 = new PhysicalProduct("Teclado", "Modelo compacto e silencioso, " + 
    "perfeito para produtividade diária. ", 80.00m, "Imagem");

Console.WriteLine($"Imagem: {item1.Image}");
item1.Image = "Nova Imagem";
Console.WriteLine($"Imagem: {item1.Image}");

DiditalProduct item2 = new DiditalProduct("Curso", "OO em C#", 100.00m, "Imagem ilustrativa", "Link");

item1.ProductNote(10, "Excelente!");
Console.WriteLine(@$"Dados do item 1:
    Nome: {item1.Name};
    Descrição: {item1.Description};
    Preço: {item1.Price};
    Estoque: {item1.Stock};
    Nota: {item1.Review.Rating};
    Comentário: {item1.Review.Comment}
");

Console.WriteLine("------------------------------");

Console.WriteLine(@$"Dados do item 2:
    Nome: {item2.Name};
    Descrição: {item2.Description};
    Preço: {item2.Price};
    Link: {item2.LinkDownload};
    Está expirado: {item2.IsExpired()}
");

Order order = new Order(1, "Teste", 100.00m);
order.ShowResum();