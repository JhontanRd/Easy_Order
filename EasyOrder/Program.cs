using EasyOrder.Controllers;
using EasyOrder.Models.Entities;
using EasyOrder.Models.Exceptions;

namespace EasyOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando a criação de objetos modelos\n\n");

            try
            {
                ClientController ct = new ClientController();
                Client client = ct.CreateClient("Jhonatan", "jhon.devbr@gmail.com", new DateTime(2026, 1, 17, 0, 0, 0)); // Status OK

                ProductController pc = new ProductController();
                Product product = pc.CreateProduct("Playstation 5", 3899.99m, 13); // Status OK

                Console.WriteLine(client);
                Console.WriteLine(product);
            }
            catch (EntityException ex)
            {
                Console.WriteLine($"Erro na aplicação: {ex.Message}");
            }
           
        }
    }
}
