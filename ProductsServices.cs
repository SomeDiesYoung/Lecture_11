using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class ProductsServices
    {
        public List<Product> GetProducts() {

            List<Product> list = new List<Product> {
                new Product(
                    "Milk",
                    "Goth Mommy",
                    99.99m),
                new Product(
                    "Beef",
                    "My ex`s Boyfriend",
                    1.99m),
                new Product(
                    "Manga",
                    "Berserk",
                    5.59m)
                };

            return list;
        }
    }
}
