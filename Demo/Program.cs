using System.ComponentModel.DataAnnotations.Schema;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Restriction Operators
            #region Find all products that are out of stock
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Find all products that are in stock and cost more than 3.00 per unit
            //var Result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice>3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region  Returns digits whose name is shorter than their value
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //?
            #endregion
            #endregion
            #region Element Operators
            #region Get first Product out of Stock
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0).FirstOrDefault();
            //Console.WriteLine(Result);
            #endregion
            #region Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductsList.Where(p => p.UnitPrice>1000).FirstOrDefault();
            //Console.WriteLine(Result);
            #endregion
            #region Retrieve the second number greater than 5
            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(x => x > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);
            #endregion
            #endregion
            #region Aggregate Operators
            #region Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(p=> p%2 != 0);
            //Console.WriteLine(result); 
            #endregion
            #region Return a list of customers and how many orders each has.
            //var result = CustomersList.SelectMany(c => c.Orders).Count();
            //Console.WriteLine(result);
            #endregion
            #region Return a list of categories and how many products each has
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { ProductCategory = p.Key , ProductCount= p.Count() }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum(x => x);
            //Console.WriteLine(result);
            #endregion
            #region Get the total units in stock for each product category
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { ProductCategory = p.Key, UnitsInStock = p.Select(p => p.UnitsInStock).Count() }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Get the cheapest price among each category's products
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { ProductCategory = p.Key, ProductCount = p.Min(p=>p.UnitPrice) }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Get the products with the cheapest price in each category (Use Let)
            //var result = from p in ProductsList
            //                       group p by p.Category into g
            //                       let minPrice = g.Min(p => p.UnitPrice)
            //                       from p in g
            //                       where p.UnitPrice == minPrice
            //                       select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Get the most expensive price among each category's products
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { ProductCategory = p.Key, ProductCount = p.Max(p=>p.UnitPrice) }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Get the products with the most expensive price in each category.
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { ProductCategory = p.Key, ProductCount = p.Max(p=>p.UnitPrice) }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Get the average price of each category's products
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { ProductCategory = p.Key, ProductCount = p.Average(p => p.UnitPrice) }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region Ordering Operators
            #region Sort a list of products by name
            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.Sort(Arr, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in Arr)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Sort a list of products by units in stock from highest to lowest.
            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.OrderBy(x => x.Length).ThenBy(x => x).ToArray();
            //foreach (var name in Result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
            #region Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(x => x.Length).ThenBy(x => x, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var word in Result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result =ProductsList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenByDescending(x => x, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #endregion
            #region Transformation Operators
            #region Return a sequence of just the names of a list of products
            //var result = ProductsList.Select(p => p.ProductName).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(word => new { UpperCase = word.ToUpper(), LowerCase = word.ToLower() }).ToList();

            //foreach (var word in result)
            //{
            //    Console.WriteLine($"UpperCase: {word.UpperCase}, LowerCase: {word.LowerCase}");
            //}
            #endregion
            #region Select all orders where the order total is less than 500.00
            //var result = CustomersList.SelectMany(c => c.Orders);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

        }
    }
}
