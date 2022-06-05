using System.Data;
using System.Data.SqlClient;

namespace DisconnectedMode
{
    class Program
    {
        public static void Main()
        {
            #region Connected
            //
            // string ConnectionString = "Data Source=DESKTOP-KNH15NM;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // string query = "select * from Teachers";
            //
            // using SqlConnection conn = new SqlConnection(ConnectionString);
            // conn.Open();
            //
            // using SqlCommand cmd = new SqlCommand(query, conn);
            //
            // SqlDataReader reader = cmd.ExecuteReader();
            //
            // for (int i = 0; i < reader.FieldCount; i++)
            // {
            //     Console.Write($"{reader.GetName(i)}\t");
            // }
            //
            // Console.WriteLine();
            //
            // while (reader.Read())
            // {
            //     Console.WriteLine($"{reader.GetValue(0)}\t{reader.GetValue(1)}\t{reader.GetValue(2)}");
            // }


            #endregion

            #region DisConnected
            string ConnectionString = "Data Source=DESKTOP-KNH15NM;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = "select * from Teachers";

            //using SqlConnection conn = new SqlConnection(ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionString);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);


            DataSet ds = new DataSet();

            adapter.Fill(ds);

            DataTableCollection tables = ds.Tables;

            DataColumnCollection columns = tables[0].Columns;
            DataRowCollection rows = tables[0].Rows;


            foreach (DataColumn column in columns)
            {
                Console.Write(column.ColumnName + '\t');
            }

            Console.WriteLine();

            foreach (DataRow row in rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + '\t');
                }
                Console.WriteLine();
            }

            
            adapter.AcceptChangesDuringUpdate = true;
            
            ds.Tables[0].Rows[0][1] = "Test5";


            adapter.Update(ds);


            
            #endregion

        }
    }
}

