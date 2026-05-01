using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BMS
{
    public class Connection
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private string ConStr;
        private SqlDataAdapter sda;
        public SqlDataReader ActiveReader { get; private set; }
        private SqlDataReader reader;


        public int SetData(string Query)
        {
            int Cnt;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = Query;
            Cnt = cmd.ExecuteNonQuery();
            con.Close();
            return Cnt;
        }

        public SqlDataReader GetDataReader(string Query)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = Query;
            reader = cmd.ExecuteReader();
           
            return reader;
           
           
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConStr);
            sda.Fill(dt);
            return dt;
        }
        public Connection()
        {
            ConStr = @"Data Source=LAPTOP-QR7621L4\SQLEXPRESS02;Initial Catalog=Bakery_Management_System;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True";
            con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = con;

        }
   

    }
}
