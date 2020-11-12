using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Dappers
{
    class Program
    {
        //public class Car
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public int Price { get; set; }

        //    public override string ToString()
        //    {
        //        return $"{Id} {Name} {Price}";
        //    }
        //}
        static void Main(string[] args)
        {
            //var cs = @"Server=DESKTOP-GG675F6;Database=test;Trusted_Connection=True;";
            //Car carss;

            //using (var con = new SqlConnection(cs))
            //{
            //    con.Open();
            //The ExecuteScalar() method executes a query that selects a single value.
            //var version = con.ExecuteScalar<string>("SELECT @@VERSION");
            //Console.WriteLine(version);
            //Console.WriteLine();

            //The Query() method executes the SELECT * FROM cars statement and returns a list of objects.
            //var cars = con.Query<Car>("SELECT * FROM tblCars").ToList();
            //cars.ForEach(car => Console.WriteLine(car));

            ////DynamicParameters query
            //var query = "INSERT INTO tblCars(Id,name, price) VALUES(@id, @name, @price)";

            //var dp = new DynamicParameters();
            //dp.Add("@id", 6);
            //dp.Add("@name", "BMW", DbType.AnsiString, ParameterDirection.Input, 255);
            //dp.Add("@price", 8000600);

            //int res = con.Execute(query, dp);

            //if (res > 0)
            //{
            //    Console.WriteLine("row inserted");
            //}

            //Execute. The UPDATE statement updates the price of a car. The Execute() method returns the number of updated rows.
            //int nOfRows = con.Execute("UPDATE dbo.[tblCars] SET [price] = 4000000 WHERE [id] = 2");
            //Console.WriteLine();
            //Console.WriteLine("'UPDATE' affected rows: {0}", nOfRows);

            //The QueryFirst()/parameterized query returns the first result of the SQL query. The @id is a placeholder to be filled. The second argument is the parameter to fill the placeholder.
            //var singleCar = con.QueryFirst<Car>("SELECT * FROM tblCars WHERE id=@id", new { id = 3 });
            //Console.WriteLine();
            //Console.WriteLine(singleCar);

            //con.Close();

            //Anonymous Methods
            PerformBasicCalculations calc = delegate (int x, int y)
            {
                Console.WriteLine("Addition");
                return x + y;
            };
            var result = calc(2, 3);
            Console.WriteLine(result);

            //Lamda Methods
            PerformBasicCalculations calcu = (a, b) =>
            {
                Console.WriteLine("Addition");
                return a + b;
            };
            var results = calc(4, 3);
            Console.WriteLine(results);

            Console.ReadLine();

        }

        public delegate int PerformBasicCalculations(int x, int y);

    }
}
