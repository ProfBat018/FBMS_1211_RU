using System;
using System.Data.SqlClient;

namespace ConnectedMode
{
    // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;

    class Program
    {
        public static void Main()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;";

            using SqlConnection connection = new(connectionString);
            connection.Open();

            Console.WriteLine("Enter name: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter surname: ");
            string? surname = Console.ReadLine();

            string query = "insert into Teachers values(1, @name, 9999, @surname)";

            using SqlCommand command = new(query, connection);

            SqlParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@name";
            parameter.Value = name;

            command.Parameters.Add(parameter);

            SqlParameter parameter2 = command.CreateParameter();
            parameter2.ParameterName = "@surname";
            parameter2.Value = surname;

            command.Parameters.Add(parameter2);


            var res = command.ExecuteNonQuery();

            Console.WriteLine(res);
        }
    }
}