using Demo01.Data;
using System.Xml;

namespace assi1linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            //var outOfStockProducts = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0).ToList();
            //Console.WriteLine("Out of Stock Products:");
            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine(product);
            //}
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var digitsShorterThanValue = Arr
            //    .Select((name, index) => new { Digit = index, Name = name })
            //    .Where(x => x.Name.Length < x.Digit)
            //    .Select(x => x.Digit)
            //    .ToList();

            //Console.WriteLine("Digits whose name is shorter than their value:");
            //foreach (var digit in digitsShorterThanValue)
            //{
            //    Console.WriteLine(digit);
            //}


            #endregion
            #region Element Operators
            //list<product> products = new list<product>();
            //var firstoutofstock = products.firstordefault(p => p.unitsinstock == 0);
            //console.writeline($"first out of stock product: {firstoutofstock?.productname ?? "none"}")
            //var expensiveproduct = products.firstordefault(p => p.unitprice > 1000);
            //console.writeline($"first expensive product: {expensiveproduct?.productname ?? "none"}");
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondgreaterthanfive = arr.where(n => n > 5).elementatordefault(1);
            //console.writeline($"second number greater than 5: {secondgreaterthanfive}");

            #endregion
            #region Aggregate Operators

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int oddCount = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine($"Number of odd numbers: {oddCount}");

            //List<Customer> customers = new List<Customer>();
            //var customerOrders = customers
            //    .Select(c => new { c.CustomerName, cust.OrderCount = c.Orders.Count });

            //Console.WriteLine("Customers and their order counts:");
            //foreach (var cust in customerOrders)
            //{
            //    Console.WriteLine($"{cust.Name}: {cust.OrderCount} orders");
            //}

            //List<Product> products = new List<Product>();
            //var categoryProductCount = products
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, ProductCount = g.Count() });

            //Console.WriteLine("Categories and product counts:");
            //foreach (var category in categoryProductCount)
            //{
            //    Console.WriteLine($"{category.Category}: {category.ProductCount} products");
            //}
            //int totalSum = Arr.Sum();
            //Console.WriteLine($"Total sum of numbers: {totalSum}");

            //string filePath = "dictionary_english.txt";
            //if (File.Exists(filePath))
            //{
            //    string[] words = File.ReadAllLines(filePath);
            //    int totalCharacters = words.Sum(w => w.Length);
            //    Console.WriteLine($"Total number of characters: {totalCharacters}");

            //    int shortestWordLength = words.Min(w => w.Length);
            //    Console.WriteLine($"Shortest word length: {shortestWordLength}");
            //    int longestWordLength = words.Max(w => w.Length);
            //    Console.WriteLine($"Longest word length: {longestWordLength}");
            //    double averageWordLength = words.Average(w => w.Length);
            //    Console.WriteLine($"Average word length: {averageWordLength:F2}");
            //}
            //else
            //{
            //    Console.WriteLine("File not found: dictionary_english.txt");
            //}
            #endregion
            #region Ordering Operators
            //List<Product> products = new List<Product>();
            //var sortedByName = products.OrderBy(p => p.ProductName).ToList();

            //Console.WriteLine("Products sorted by name:");
            //foreach (var product in sortedByName)
            //    Console.WriteLine(product.ProductName);
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var caseInsensitiveSorted = words.OrderBy(w => w, StringComparer.OrdinalIgnoreCase).ToArray();

            //Console.WriteLine("\nWords sorted case-insensitively:");
            //Console.WriteLine(string.Join(", ", caseInsensitiveSorted));
            //var sortedByStock = products.OrderByDescending(p => p.UnitsInStock).ToList();

            //Console.WriteLine("\nProducts sorted by stock (highest to lowest):");
            //foreach (var product in sortedByStock)
            //    Console.WriteLine($"{product.ProductName} - {product.UnitsInStock} units");
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d).ToArray();

            //Console.WriteLine("\nDigits sorted by length, then alphabetically:");
            //Console.WriteLine(string.Join(", ", sortedDigits));
            //var sortedWordsByLength = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase).ToArray();

            //Console.WriteLine("\nWords sorted by length, then case-insensitively:");
            //Console.WriteLine(string.Join(", ", sortedWordsByLength));
            //var sortedByCategoryAndPrice = products
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice)
            //    .ToList();

            //Console.WriteLine("\nProducts sorted by category, then by price (highest to lowest):");
            //foreach (var product in sortedByCategoryAndPrice)
            //    Console.WriteLine($"{product.Category}: {product.ProductName} - ${product.UnitPrice}");
            //var sortedWordsByLengthDesc = words
            //    .OrderBy(w => w.Length)
            //    .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase)
            //    .ToArray();
            //Console.WriteLine("\nWords sorted by length, then case-insensitively (descending):");
            //Console.WriteLine(string.Join(", ", sortedWordsByLengthDesc));
            //var filteredReversedDigits = digits
            //    .Where(d => d.Length > 1 && d[1] == 'i')
            //    .Reverse()
            //    .ToArray();

            //Console.WriteLine("\nDigits whose second letter is 'i', reversed:");
            //Console.WriteLine(string.Join(", ", filteredReversedDigits));
            #endregion
            #region Transformation Operators
            List<Product> products = new List<Product>();
            var productNames = products.Select(p => p.ProductName).ToList();
            Console.WriteLine("Product Names:");
            Console.WriteLine(string.Join(", ", productNames));
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var transformedWords = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() }).ToList();

            Console.WriteLine("\nWords in uppercase and lowercase:");
            foreach (var word in transformedWords)
                Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");

            var productDetails = products.Select(p => new { p.ProductName, Price = p.UnitPrice, p.Category }).ToList();

            Console.WriteLine("\nProduct Details:");
            foreach (var item in productDetails)
                Console.WriteLine($"Name: {item.ProductName}, Price: {item.Price}, Category: {item.Category}");
            int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var matchingIndexes = arr.Select((value, index) => new { Value = value, Index = index, Match = value == index }).ToList();

            Console.WriteLine("\nValues matching their positions:");
            foreach (var item in matchingIndexes.Where(x => x.Match))
                Console.WriteLine($"Index {item.Index} matches Value {item.Value}");
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var numberPairs = from a in numbersA
                              from b in numbersB
                              where a < b
                              select new { A = a, B = b };

            Console.WriteLine("\nPairs where numbersA < numbersB:");
            foreach (var pair in numberPairs)
                Console.WriteLine($"({pair.A}, {pair.B})");
            List<Order> orders =  new List<Order>();
            var smallOrders = orders.Where(o => o.Total < 500).ToList();

            Console.WriteLine("\nOrders with Total Amount < 500:");
            foreach (var order in smallOrders)
                Console.WriteLine($"Order ID: {order.OrderID}, Total: {order.Total}");
            var recentOrders = orders.Where(o => o.OrderDate.Year >= 1998).ToList();

            Console.WriteLine("\nOrders from 1998 or later:");
            foreach (var order in recentOrders)
                Console.WriteLine($"Order ID: {order.OrderID}, Date: {order.OrderDate.ToShortDateString()}");
        
        #endregion

    }
    }
}
