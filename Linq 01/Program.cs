using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static Linq_01.ListGenerator;
namespace Linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators

            #region 1. Find all products that are out of stock.
            //var ProductsOutOfStock = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var product in ProductsOutOfStock)
            //{
            //    Console.WriteLine($"{product.ProductName} is out of stock.");
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var ProductsInStockAndCostMoreThan3PerUnit = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
            //foreach (var product in ProductsInStockAndCostMoreThan3PerUnit)
            //{
            //    Console.WriteLine($"{product.ProductName} is in stock and costs more than 3.00 per unit.");
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four",
            //     "five", "six", "seven", "eight", "nine" };

            //var DigitsWhoseNameIsShorterThanTheirValue = Arr.Where((digit, index) => digit.Length < index);
            //foreach (var digit in DigitsWhoseNameIsShorterThanTheirValue)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #endregion

            #region Tranforming Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var ProductNames = ProductsList.Select(p => p.ProductName);
            //foreach (var name in ProductNames)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var UpperAndLowerCaseWords = words.Select(word => new
            //{
            //    UpperCase = word.ToUpper(),
            //    LowerCase = word.ToLower()
            //});
            //foreach (var word in UpperAndLowerCaseWords)
            //{
            //    Console.WriteLine($"Uppercase: {word.UpperCase}, Lowercase: {word.LowerCase}");
            //}
            #endregion
            
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var ProductProperties = ProductsList.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    Price = p.UnitPrice
            //});
            //foreach (var product in ProductProperties)
            //{
            //    Console.WriteLine($"ProductID: {product.ProductID}, ProductName: {product.ProductName}, Price: {product.Price}");
            //}
            #endregion
            
            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var NumbersThatMatchTheirPosition = Arr.Select((number, index) => new
            //{
            //    Number = number,
            //    InPlace = (number == index)
            //});
            //foreach (var item in NumbersThatMatchTheirPosition)
            //{
            //    Console.WriteLine($"Number: {item.Number}, InPlace: {item.InPlace}");
            //}
            #endregion
            
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var NumberPairs = numbersA.SelectMany(
            //         a => numbersB,
            //         (a, b) => new { a, b })
            //         .Where(pair => pair.a < pair.b);
            //foreach (var pair in NumberPairs)
            //    {
            //    Console.WriteLine($"A: {pair.a}, B: {pair.b}");
            //}
            #endregion
            
            #region 6. Select all orders where the order total is less than 500.00.
            //var OrdersWithTotalLessThan500 = CustomersList.SelectMany(
            //         c => c.Orders,
            //         (c, o) => new { c.CustomerID, o.OrderID, o.Total })
            //         .Where(order => order.Total < 500.00M);
            //foreach (var order in OrdersWithTotalLessThan500)
            //    {
            //    Console.WriteLine($"CustomerID: {order.CustomerID}, OrderID: {order.OrderID}, Total: {order.Total}");
            //}
            #endregion
            
            #region 7. Select all orders where the order was made in 1998 or later.
            #endregion
            #endregion

            #region Ordering Operators

            #region 1. Sort a list of products by name
            //var ProductsSortedByName = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var product in ProductsSortedByName)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var WordsSortedCaseInsensitive = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in WordsSortedCaseInsensitive)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var ProductsSortedByUnitsInStock = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in ProductsSortedByUnitsInStock)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var DigitsSortedByLengthThenByName = Arr.OrderBy(digit => digit.Length).ThenBy(digit => digit);
            //foreach (var digit in DigitsSortedByLengthThenByName)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var WordsSortedByLengthThenCaseInsensitive = Arr.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in WordsSortedByLengthThenCaseInsensitive)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var ProductsSortedByCategoryThenByUnitPrice = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var product in ProductsSortedByCategoryThenByUnitPrice)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var WordsSortedByLengthThenCaseInsensitiveDescending = Arr.OrderBy(word => word.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in WordsSortedByLengthThenCaseInsensitiveDescending)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var DigitsWithSecondLetterIReversed = Arr.Where(digit => digit.Length > 1 && digit[1] == 'i').Reverse();
            //foreach (var digit in DigitsWithSecondLetterIReversed)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion
            #endregion

            #region Element Operators
            #region 1. Get first Product out of Stock 
            //var FirstProductOutOfStock = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //foreach (var product in ProductsList)
            //{
            //    Console.WriteLine(product?.ProductName??"Not Found");
            //}
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned
            //var FirstProductWithPriceGreaterThan1000 = ProductsList.FirstOrDefault(P => P.UnitPrice > 1000);
            //foreach (var product in ProductsList)
            //{
            //    Console.WriteLine(product?.ProductName ?? null);
            //}
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondGreaterThanFive =
            //                             (from n in Arr
            //                                 where n > 5
            //                                 select n)
            //                                  .Skip(1) //  بتعمل سكيب لاول واحد اكبر من 5 يعني هتعدي ال9 و تجيب ال8
            //                                  .FirstOrDefault();
            //Console.WriteLine(secondGreaterThanFive);
            #endregion
            #endregion

            #region Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var NumberOfOddNumbers = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine(NumberOfOddNumbers);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var NumberOfOrdersPerCustomer = CustomersList.Select(C => new
            //{
            //    C.CustomerID,
            //    OrderCount = C.Orders.Count()
            //});
            //foreach (var customer in NumberOfOrdersPerCustomer)
            //{
            //    Console.WriteLine($"CustomerID: {customer.CustomerID}, OrderCount: {customer.OrderCount}");
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has

            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var TotalOfNumbersInArray = Arr.Sum();
            //Console.WriteLine(TotalOfNumbersInArray);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            //string[] Words = { "dictionary_english.txt" };
            //int TotalNumOfChars = Words.Sum(W => W.Length);
            //Console.WriteLine($"Total Number Of Characters = {TotalNumOfChars}");
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = { "dictionary_english.txt" };
            //var LengthOfShortestWord = Words.Min(W => W.Length);
            //Console.WriteLine($"Length Of Shortest Word = {LengthOfShortestWord}");
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = { "dictionary_english.txt" };
            //var LengthOfLongestWord = Words.Max(W => W.Length);
            //Console.WriteLine($"Length Of Longest Word = {LengthOfLongestWord}");
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            //string[] Words = { "dictionary_english.txt" };
            //var AverageLengthOfWords = Words.Average(W => W.Length);
            //Console.WriteLine($"Average Length Of Words = {AverageLengthOfWords}");
            #endregion
            #endregion

        }
    }
}
