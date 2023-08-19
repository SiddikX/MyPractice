using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class DataUtility
    {
        private SqlConnection _conn;
        public DataUtility(string connectionString)
        {
            _conn = new SqlConnection(connectionString);

        }

        private SqlCommand CreateCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _conn);
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            return cmd;
        }
        public void ExecuteSql(string sql)
        {
            using SqlCommand cmd = CreateCommand(sql);
            cmd.ExecuteNonQuery();
        }

        public IList<Dictionary<string, object>> ReadData(string query)
        {
            using SqlCommand cmd = CreateCommand(query);
            using SqlDataReader reader = cmd.ExecuteReader();

            List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

            while(reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }
                data.Add(row);
            }
            return data;
        }
    }
}
