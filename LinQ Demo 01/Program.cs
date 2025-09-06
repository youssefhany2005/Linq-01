namespace LinQ_Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                #region Implictly Type Local Variable [var - dynamic]

                #region Var Keyword
                //string Data = "Ahmed";
                //var Data = "Ahmed"; // Implictly Type 
                //                    // Compiler will detect Datatype of variable at compilation time
                //                    // Based on its inital value 

                ////var x = null; // invalid 

                //Data = null;
                //var Data; // Inavlid 
                //Data = "Mustafa";

                //Data = 10; // Invalid 
                #endregion

                #region dynamic keyword
                //dynamic Data = "Ali";
                // CLR Will detect Datatype of variable at runtime
                // based on its last assigned value

                //dynamic X;

                //dynamic Y = 10;

                //Data = 10;

                //Console.WriteLine(Data);
                //Data = true;
                //Console.WriteLine(Data);

                #endregion

                #endregion

                //=====================================================

                #region Extension Method
                //int X = 12345;
                //int Y = X.Reverse();
                //Console.WriteLine(Y);

                //long A = 123456789156;
                //long B = A.Reverse();
                //Console.WriteLine(B);
                #endregion

                //=====================================================


                #region Anonymous Type
                //Employee employee = new Employee() { Id = 10, Name = "Mona", Salary = 8000 };

                //object Emp01 = new { Id = 10, Name = "Mona", Salary = 8000 };

                //Console.WriteLine(Emp01);

                //var Emp03 = new { Id = 10, Name = "Mona", Salary = 8000 };

                //Console.WriteLine(Emp03.GetType().Name); // <>f__AnonymousType0`3

                //var Emp04 = new { Id = Emp03.Id, Name = Emp03.Name, Salary = 5000 };

                //Console.WriteLine(Emp04.GetType().Name);

                //var Emp05 = Emp03 with { Salary = 4000 };

                //Console.WriteLine(Emp05.GetType().Name);

                //var Emp06 = new { id = 10, Name = "Mona", Salary = 8000 };
                #endregion

                //=====================================================


                #region What is LINQ
                //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                //List<int> oddNumbers = Numbers.Where(num => num % 2 == 0).ToList();

                //foreach (var num in oddNumbers)
                //{
                //    Console.WriteLine(num);
                //}
                #endregion

                //=====================================================


                #region Linq Syntax [Fluent - Query]
                //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                #region Fluent Syntax
                //List<int> oddNumbers = Numbers.Where(num => num % 2 == 0).ToList();

                //Fluent Syntax as a Static Method
                //List<int> OddNumbers = Enumerable.Where(Numbers, num => num % 2 == 0).ToList();

                //Fluent Syntax as an Extension Method { Recommended}
                //List<int> oddNumbers = Numbers.Where(num => num % 2 == 0).ToList();

                //Query 
                #endregion

                #region Query Syntax
                //var OddNumbers = from N in Numbers
                //                       where N % 2 == 1
                //                       select N;

                //foreach (var item in OddNumbers)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion

                #endregion

                //=====================================================


                #region Linq Execution Ways
                #region Deffered Execution [Latest Version of Data]
                //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //var oddNumbers = Numbers.Where(num => num % 2 == 1);

                //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

                //foreach (var num in oddNumbers)
                //{
                //    Console.Write($"{num} ");
                //}
                #endregion

                #region Immediate Execution
                //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //var oddNumbers = Numbers.Where(num => num % 2 == 1).ToList();

                //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

                //foreach (var num in oddNumbers)
                //{
                //    Console.Write($"{num} ");
                //}
                #endregion
                #endregion

                //=====================================================


                #region Data Setup
                //Console.WriteLine(ProductsList[0]);
                //Console.WriteLine(CustomersList[0]);
                #endregion

                //=====================================================


                #region Filtiration [Restriction] Operators - Where
                //var Result = ProductsList.Where(P => P.UnitsInStock == 0);

                //Result = from P in ProductsList
                //         where P.UnitsInStock == 0
                //         select P;

                //foreach (var Unit in Result)
                //{
                //    Console.WriteLine(Unit);
                //}

                //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

                //Result = from P in ProductsList
                //         where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
                //         select P;

                //Result = ProductsList.Where((P, I) => I < 10 && P.UnitsInStock == 0);

                //foreach (var Unit in Result)
                //{
                //    Console.WriteLine(Unit);
                //}
                #endregion

                //=====================================================


                #region Transformation [Projection] Operators [Select, Select Many]
                //var Result = ProductsList.Select(P => P.ProductName);

                //Result = from PN in ProductsList
                //         select PN.ProductName;

                //foreach (var item in Result)
                //{
                //    Console.WriteLine(item);
                //}

                //var Result = CustomersList.Select(C => C.CustomerName);

                //Result = from C in CustomersList
                //         select C.CustomerID;

                //foreach (var item in Result)
                //{
                //    Console.WriteLine(item);
                //}

                //var Result = CustomersList.Select(C => C.Orders).ToList();

                //Result = from C in CustomersList
                //         from O in C.Orders
                //         select O;

                //var Result = ProductsList.Select(P => new {  P.ProductID, P.ProductName});

                //Result = from P in ProductsList
                //         select new
                //         {
                //              P.ProductID,
                //              P.ProductName,
                //         };

                //var Result = ProductsList.Where(P => P.UnitsInStock == 0).Select(P => new
                //{
                //    Id = P.ProductID,
                //    Name = P.ProductName,
                //    OldPrice = P.UnitPrice,
                //    NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M),
                //});

                //Result = from P in ProductsList
                //         where P.UnitsInStock > 0
                //         select new
                //         {
                //             Id = P.ProductID,
                //             Name = P.ProductName,
                //             OldPrice = P.UnitPrice,
                //             NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
                //         };

                //var Result = ProductsList.Where(P => P.UnitsInStock > 0)
                //                         .Select((P, I) => new
                //                         {
                //                             Index = I,
                //                             Name = P.ProductName
                //                         });

                //foreach (var item in Result)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion

                //=====================================================


                #region Ordering Operators
                //var Result = ProductsList.OrderBy(P => P.UnitPrice);

                //Result = from P in ProductsList
                //         orderby P.UnitPrice
                //         select P;

                //var Result = ProductsList.OrderByDescending(P => P.UnitPrice);

                //Result = from P in ProductsList
                //         orderby P.UnitPrice descending
                //         select P;

                //var Result = ProductsList.OrderBy(P => P.UnitPrice).ThenByDescending(P => P.UnitsInStock).Reverse();

                //foreach (var item in Result)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion

                //=====================================================


                #region Elemets Operator - Immediate Execution
                //var Result = ProductsList.FirstOrDefault(P => P.UnitsInStock == 0);

                //Result = ProductsList.LastOrDefault(P => P.UnitsInStock == 0);

                //Console.WriteLine(Result);

                //var Result = ProductsList.Single();
                #endregion

                //=====================================================


                #region Aggregate Operators [Immediate Execution]
                //var Result = ProductsList.Max(P => P.ProductName.Length);

                //string[] Names = { "Aya", "Mona", "Ahmed", "Mahmoud" };

                //var Result = Names.Aggregate((str01, str02) => $"{str01} {str02}");

                //Console.WriteLine(Result);

                //Console.WriteLine(Result);
                #endregion
            }
        }
    }
}
