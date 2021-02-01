// IFEGBESAN OLUWATOMISIN OLAMIDE
// EES/18/19/0267

using System;

namespace Polymorphism
{
    public class OracleConenction : DbConnection
    {
        public OracleConenction(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnetion is open.");
        }

        public override void Close()
        {
            Console.WriteLine("OracleConnection is closed.");
        }
    }
}