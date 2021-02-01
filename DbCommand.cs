// IFEGBESAN OLUWATOMISIN OLAMIDE
// EES/18/19/0267


using System;

namespace Polymorphism
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new ArgumentException("DbConnection cannot be null.");
            if (String.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("The instruction cannot be null, whitespace or empty");
            
            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Instruction: " + _instruction);
            _dbConnection.Close();
        }
    }
}