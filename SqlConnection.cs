// IFEGBESAN OLUWATOMISIN OLAMIDE
// EES/18/19/0267



using System;

namespace Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("SqlConnection is open.");
        }

        public override void Close()
        {
            Console.WriteLine("SqlConnection is closed.");
        }
    }
}