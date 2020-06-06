using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditPlan
{
    class SQL_Queires
    {
        SqlConnection con = new SqlConnection("Data Source=MASHOOD;Initial Catalog=AuditPlan;Integrated Security=True");

        public void InsertData(String query)
        {
            try
            {
                con.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }
        public void DeleteData(String query)
        {
            try
            {
                con.Open();
                SqlDataAdapter Del = new SqlDataAdapter(query, con);
                Del.SelectCommand.ExecuteNonQuery();
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }
        public void ShowGVData(String query, DataGridView obj)
        {
            try
            {
                con.Open();
                SqlDataAdapter Data = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                Data.Fill(dt);
                obj.DataSource = dt;
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
