using System.Globalization;

namespace EasyOrder.Models.Entities
{
    class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"-> ID: {Id}, Nome: {Name}, Quantidade em estoque {Stock},\n\tPrice: {Price.ToString("C2", new CultureInfo("pt-br"))}";
        }
    }
}
