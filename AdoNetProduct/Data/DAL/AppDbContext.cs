using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbContext
    {
        string connectionStr = "Server=DESKTOP-4VAU7GI\\SQLEXPRESS;" +
                        "Database=ProductsDb;" +
                        "Trusted_Connection=true;" +
                        "Integrated Security=true;" +
                        "TrustServerCertificate=true;";

        SqlConnection sqlConnection;

        public AppDbContext()
        {
            sqlConnection = new SqlConnection(connectionStr);
        }


        public void NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            var result = sqlCommand.ExecuteNonQuery();

            if(result > 0)
            {
                Console.WriteLine($"{result} row affected");
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }

            sqlConnection.Close();
        }

        public DataTable Query(string selectCommand)
        {
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, sqlConnection);
            DataTable dataTable =  new DataTable();
            dataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

    }
}
