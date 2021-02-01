// IFEGBESAN OLUWATOMISIN OLAMIDE
// EES/18/19/0267

using System;

namespace Polymorphism
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeout;

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("The connection string cannot be null, whitespace or empty");

            _connectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }
}