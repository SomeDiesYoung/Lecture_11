using System.Collections.Generic;
using System.Diagnostics;
namespace ConsoleApp1;

public partial class Program
{
    static void Main()
    {
        var productService = new ProductsServices();

        var list = productService.GetProducts();

        List<int> numbers = new List<int> { 1, 52, -63, 73, 86, 2, 15, 8, 52, -95, -32 };

        var max = numbers.Aggregation(numbers[0], (a, b) => a > b ? a : b);

        var min = numbers.Aggregation(numbers[0], (a, b) => a < b ? a : b);

        int number = 52;
        var firstIndexOf = numbers.CycleFromStartToEnd(number, (a, b) => a.Equals(b));

        var lastIndexOf = numbers.CycleFromEndToStart(number, (a, b) => a.Equals(b));

        var prices = list.Transform(item => item.Price);

        var totalPrice = prices.AggregationForPrices(0, (a, b) => a + b);

        var lowestPrice = numbers.Find(number => number < 0);

        var highestPrice = numbers.Find(number => number > 0);

        Console.ReadLine();
    }
}
