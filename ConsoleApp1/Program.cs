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

            #region Ordaring Operatoers
            // Ordaring Operatoers


            //var result = ProductList.OrderBy(P => P.UnitPrice).Select(P => new
            //{
            //    P.ProductName,
            //    P.UnitsInStock,
            //    P.UnitPrice
            //});

            //var result = ProductList.OrderBy(P => P.UnitsInStock).Select(P => new
            //{
            //    P.ProductName,
            //    P.UnitsInStock,
            //    P.UnitPrice
            //});

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock).Select(P => new
            //{
            //    P.ProductName,
            //    P.UnitsInStock,
            //    P.UnitPrice
            //});

            //var result = ProductList.OrderByDescending(P => P.UnitPrice).Select(P => new
            //{
            //    P.ProductName,
            //    P.UnitsInStock,
            //    P.UnitPrice
            //});

            //var result = ProductList.Where(P => P.Category =="Meat/Poultry" && P.UnitsInStock > 0)
            //    .OrderByDescending(P => P.UnitsInStock)
            //    .ThenBy(P => P.UnitPrice)
            //    .Select(P => new
            //{
            //    P.ProductName,
            //    P.UnitsInStock,
            //    P.UnitPrice
            //});


            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry" && P.UnitsInStock > 0
            //             orderby P.UnitPrice , P.UnitsInStock descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitsInStock,
            //                 P.UnitPrice
            //             };






            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}

            ////foreach (var unit in ProductList)
            //{
            //    Console.WriteLine(unit);
            //}


            #endregion

            #region Elements Operator - Immediate Execution
            // Elements Operator - Immediate Execution

            //ProductList = new List<Product>();

            //var result =ProductList.First();
            //var result = ProductList.Last();

            //var result = ProductList.First(P => P.UnitsInStock == 0);
            //var result = ProductList.Last(P => P.UnitsInStock == 0);

            //var result = ProductList.FirstOrDefault( new Product() { ProductName= "Defult Producte" } );
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 5000000000, new Product() { ProductName = "Defult Producte" });

            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "Defult Producte" });
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 5000000000, new Product() { ProductName = "Defult Producte" });

            //var result = ProductList.ElementAt(0);
            //var result = ProductList.ElementAtOrDefault(1);

            //var result = ProductList.Single();
            //var result = ProductList.SingleOrDefault();




            //Console.WriteLine(result?.ProductName ?? "NA");

            #endregion

            #region Agregate Operatoers
            // Agregate Operatoers

            // count - Sum - Max - Min - Avg

            //Count
            //var result = ProductList.Count();//77
            //var result = ProductList.Count;//77
            //var result = ProductList.Count(p => p.UnitsInStock == 0);//5
            //var result = ProductList.Where(p => p.UnitsInStock == 0).Count();

            //Sum 
            //var result = ProductList.Sum(p => p.UnitPrice);//2222.7100
            //var result = ProductList.Sum(p => p.UnitsInStock); //3180

            //Avg
            //var result = ProductList.Average(p => p.UnitPrice);//28.866363636363636363636363636

            //Max
            //var result = ProductList.Max();// $263.50,
            //var result = ProductList.Max( new ProductComparebleUnitInStock ()  );// 125
            //var result = ProductList.Max(p => p.UnitPrice);//263.5000
            //var result = ProductList.Max(p => p.UnitsInStock);//125
            //var MaxPrice = ProductList.Max(p => p.UnitPrice);
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice == MaxPrice);
            //var result = ProductList.MaxBy(p => p.UnitPrice);

            //Min
            //var result = ProductList.Min();// $2.50
            //var result = ProductList.Min(new ProductComparebleUnitInStock());// 0
            //var result = ProductList.Min(p => p.UnitPrice);//2.5000
            //var result = ProductList.Min(p => p.UnitsInStock);//0
            //var MinPrice = ProductList.Min(p => p.UnitPrice);
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice == MinPrice);
            //var result = ProductList.MinBy(p => p.UnitPrice);

            //Aggregate
            // List<string> Names = new List<string>() { "Ahmed", "Ali" , "Omar" , "Osama" };
            //var result = Names.Aggregate((S01 , S02) => $"{S01} {S02}")   ;


            // Console.WriteLine(result);

            #endregion


        }
    }
}
