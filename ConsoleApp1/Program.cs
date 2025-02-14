using System.Collections;
using static ConsoleApp1.ListGenerator;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Where & Typof
            // 1. Filteratio Operator - Where / OfType

            // all product out of stuck


            // fluent syntx
            //var result = ProductList.Where(P => P.UnitsInStock == 0);

            // query ssyntx
            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry");
            //var result = from p in ProductList
            //             where p.Category== "Meat/Poultry"
            //             select p;

            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where(P => P.Category == "Meat/Poultry");
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;


            // Index where Valid only in Fluent Syntax
            //var result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            //var result = ProductList.Where((P, Index) => Index < 5);
            //var result = ProductList.Where((P, Index) => Index < 5 && P.UnitsInStock > 0);
            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where((P, I) => I < 5);

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 2.5m, 4.5m, ProductList[0], ProductList[1] };
            //var result = arrayList.OfType<float>();


            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}

            #endregion


            #region Select & SelectMany
            // 2. Transformation Operator --> select / SelectMany

            // Fluent syntax
            //var result =  ProductList.Select(P => P);
            //var result = ProductList.Select(P => P.ProductName);


            //var result = from P in ProductList
            //             select P.ProductName;

            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category=="Seafood")
            //                        .Select(P => new {P.ProductName,
            //                                          P.Category,
            //                                          oldPrice=P.UnitPrice,
            //                                          newprice=P.UnitPrice - P.UnitPrice*0.1m });



            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 oldPrice = P.UnitPrice,
            //                 newprice = P.UnitPrice - P.UnitPrice * 0.1m
            //             };



            //var result = CustomerList.Select(c => c.CustomerName);
            //var result = CustomerList.Select(c => c.Orders);// If One Of The Properte is sequance
            //var result = CustomerList.SelectMany(c => c.Orders);

            //var result = from c in CustomerList
            //             from o in c.Orders
            //             select o;

            //var result = ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5) ;




            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}

            #endregion


        }
    }
}
