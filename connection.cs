using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace SecureTransferMI
{
    class connection
    {
        public SqlDataReader dr;
  
        
        public SqlConnection con()
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=mossaic;uid=sa;pwd=yuva");
            con.Open();
            return con;
        }
        public int exec(string str)
        {
            SqlCommand cmd = new SqlCommand(str, con());
            return cmd.ExecuteNonQuery();
        }
        public SqlDataReader sdr(string str)
        {
            SqlCommand cmd = new SqlCommand(str, con());
            return cmd.ExecuteReader();

        }
        public DataSet ds(string str)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(str, con());
            sda.Fill(ds);
            return ds;
        }
       
        public int exec1(string str)
        {
            SqlCommand cmd = new SqlCommand(str, con());
            return cmd.ExecuteNonQuery();
        }
        public SqlDataReader ret_dr(string str)
        {
            SqlCommand cmd = new SqlCommand(str, con());
            return cmd.ExecuteReader();
        }
        public DataSet ret_ds(string str)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter(str, con());
            sqlda.Fill(ds);
            return ds;
        }
     

    }
}
