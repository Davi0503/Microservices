using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollecion)
        {
            bool existProduct = productCollecion.Find(p => true).Any();

            if (!existProduct)
            {
                var TESTE = GetMyProducts();
                productCollecion.InsertManyAsync(TESTE);
            }
        }
        public static IEnumerable<Product> GetMyProducts()
        {

            return new List<Product>() {
            new Product()
            {
                Id = "612b9498cedf282466783353",
                Name = "Miojo",
                Description = "lalalalalalalalalal lalalalalallaalall alalalalalala",
                Category = "Alimento",
                Price = 50
            },
            new Product()
            {
                Id = "612b94a1a41d46016cefeee9",
                Name = "Iphone",
                Description = "lalalalalalalalalal lalalalalallaalall alalalalalala",
                Category = "Celular",
                Price = 5000
            }
        };

        }

    }
}
