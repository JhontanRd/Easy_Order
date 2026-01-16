using EasyOrder.Models.Entities;
using EasyOrder.Models.Exceptions;
using EasyOrder.Validators;

namespace EasyOrder.Controllers
{
    class ProductController
    {
        public Product CreateProduct(string name, decimal price, int stock)
        {
            if (EntityValidator<Product>.IsValidName(name))
                throw new EntityException("Informe um nome válido para o produto!");

            if(EntityValidator<Product>.IsValidPrice(price))
                throw new EntityException($"Informe um preço válido para o produto!");

            if(EntityValidator<Product>.IsValidStockQuantity(stock))
                throw new EntityException($"Informe uma quantidade válida para o produto em estoque!");

            return new Product(name, price, stock);
        }
    }
}
