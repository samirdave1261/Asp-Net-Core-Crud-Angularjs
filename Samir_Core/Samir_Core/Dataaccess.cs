using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Samir_Core
{
    public class DataAccess //<==Master DataAcces Class
    {
        public DataAccess() //<== using Own constructor
        {

        }
        public int ExcuteQuery(string Query,string cons)
        {
            SqlConnection con = null;
            int rowsUpdated = 0;
            try
            {
                con = new SqlConnection(cons);
                SqlCommand comm = new SqlCommand(Query, con);
                con.Open();
                rowsUpdated = comm.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return rowsUpdated;
        }
        public DataTable GetDatatable(string Query, string cons)
        {
            DataTable dt = new DataTable();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(cons);
                con.Open();
                SqlCommand sqlcommand = new SqlCommand(Query, con);
                sqlcommand.CommandTimeout = 2000;
                SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
                sda.Fill(dt);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
            return dt;
        }
    }
}
