using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class MyDemo
    {
        #region Filteration [Restrication] Operator [Where]
        #region Get Element out of stock 
        //// flunt syntax
        //var Result = ProductsList.Where(p => p.UnitsInStock == 0);

        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        //// query syntax
        //Result = from p in ProductsList
        //         where p.UnitsInStock == 0
        //         select p;
        #endregion
        #region Get Elemnt In Stock And Category Of Meat
        // flunt syntax 
        //var Result = ProductsList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry");
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        // query syntax
        //Result = from p in ProductsList
        //         where p.Category == "Meat/Poultry" && p.UnitsInStock > 0
        //         select p;
        #endregion
        #region Indexed Where
        //var Result = ProductsList.Where((p, i) => i < 10 && p.UnitsInStock == 0);
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #endregion
        #region Ordering Operator
        // fluent Syntax
        #region Get product order by Price Asc
        //var Result = ProductsList.OrderBy(p => p.UnitPrice); // asc
        //// Query
        //Result =from p in ProductsList
        //        orderby p.UnitPrice
        //        select p;
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #region Get product order by Price Desc
        //var Result = ProductsList.OrderByDescending(p => p.UnitPrice); // asc
        // Query
        //Result =from p in ProductsList
        //        orderby p.UnitPrice descending
        //        select p;
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #region Get product order by Price aes and number of  items in stock
        //var Result = ProductsList.OrderBy(p => p.UnitPrice).ThenBy(p => p.UnitsInStock); // asc
        //Result = ProductsList.OrderBy(p => p.UnitPrice).ThenByDescending(p => p.UnitsInStock); // Desc
        //// Query
        //Result = from p in ProductsList
        //         orderby p.UnitPrice, p.UnitsInStock descending
        //         select p;
        //foreach (var item in Result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #endregion
        #region Transformation Operatores
        #region Select Product Name
        //// fluent syntax
        //var result = ProductsList.Select(p => p.ProductName);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //// query syntax
        //result = from p in ProductsList
        //         select p.ProductName;
        #endregion
        #region Select customer name and orders
        //// fluent
        //var result = CustomersList.SelectMany(c => c.Orders);
        //// query
        //result= from c in CustomersList
        //        from o in c.Orders
        //        select o;
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #region select product id and name
        //// fluent
        //var list = ProductsList.Select(p => new {  p.ProductID,  p.ProductName,});
        //// query 
        //list = from p in list
        //       select new
        //       {
        //           p.ProductID,
        //           p.ProductName,
        //       };
        //foreach (var item in list)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #region Select Product In Stock And Apply Discount 10% on price
        ////fluent
        //var discountedlist = ProductsList.Where(p => p.UnitsInStock > 0).Select(p => new
        //{
        //    p.ProductID,
        //    p.ProductName,
        //    newprice = p.UnitPrice - (p.UnitPrice * .1M),
        //});
        //// query
        //discountedlist = from p in ProductsList
        //                 where p.ProductID > 0
        //                 select new
        //                 {
        //                     p.ProductID,
        //                     p.ProductName,
        //                     newprice = p.UnitPrice - (p.UnitPrice * .1M),
        //                 };
        //foreach (var item in discountedlist)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #region Indexed select
        //var indexedSelect = ProductsList.Select((p, i) => new { index = i, name = p.ProductName });
        //foreach (var item in indexedSelect)
        //{
        //    Console.WriteLine(item);
        //}
        //var listmany = CustomersList.SelectMany(c => c.Orders);

        //foreach (var item in listmany)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #endregion
        #region Element Operators
        //var result = ProductsList.First();
        //result = ProductsList.Last();
        //var elemnt = ProductsList.FirstOrDefault();
        //elemnt = ProductsList.LastOrDefault();
        //Console.WriteLine(result);
        #endregion
        #region Aggregate Function
        #region count
        //var countresult = ProductsList.Count();
        //countresult = ProductsList.Where(p => p.UnitsInStock == 0).Count();
        //countresult = ProductsList.Count(p => p.UnitsInStock == 0);
        //Console.WriteLine(countresult); 
        #endregion
        #region Min - Max
        //var maxpro = ProductsList.Max();
        #endregion
        #endregion
    }
}
