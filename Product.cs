namespace ConsoleApp1;

public partial class Program
{
    public class Product
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public Product(string name, string manufacturer, decimal price)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }
    }



}
