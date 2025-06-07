using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineConsole.Models;

namespace VendingMachineConsole.Service
{
    public class ProductCatalog
    {
        private readonly List<Product> _products = new()
    {
        new Product { Name = "Cola", Price = 1.00m, Stock = 5 },
        new Product { Name = "Chips", Price = 0.50m, Stock = 5 },
        new Product { Name = "Candy", Price = 0.65m, Stock = 5 },
    };

        public Product? GetProduct(string name) => _products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        public bool Vend(string name)
        {
            var product = GetProduct(name);
            if (product != null && product.Stock > 0)
            {
                product.Stock--;
                return true;
            }
            return false;
        }
    }
}
