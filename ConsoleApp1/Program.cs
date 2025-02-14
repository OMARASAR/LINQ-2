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



        }
    }
}
