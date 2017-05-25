using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class BaoCao_DAO
    {
        // Bao cao so quy
        public static DataTable SoQuy(string matk, DateTime ngaybd, DateTime ngaykt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_SoQuy", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@matk", SqlDbType.VarChar,7));
            cmd.Parameters.Add(new SqlParameter("@ngaybd", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@ngaykt", SqlDbType.DateTime));
            cmd.Parameters["@matk"].Value = matk;
            cmd.Parameters["@ngaybd"].Value = ngaybd;
            cmd.Parameters["@ngaykt"].Value = ngaykt;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

           
        }
        public static DataTable SoCai(string matk, DateTime ngaybd, DateTime ngaykt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("SoCai", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@matk", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@ngaybd", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@ngaykt", SqlDbType.DateTime));
            cmd.Parameters["@matk"].Value = matk;
            cmd.Parameters["@ngaybd"].Value = ngaybd;
            cmd.Parameters["@ngaykt"].Value = ngaykt;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
        public static DataTable sp_SoCaiTk111(string matk, DateTime ngaybd, DateTime ngaykt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_SoCaiTk111", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@matk", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@ngaybd", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@ngaykt", SqlDbType.DateTime));
            cmd.Parameters["@matk"].Value = matk;
            cmd.Parameters["@ngaybd"].Value = ngaybd;
            cmd.Parameters["@ngaykt"].Value = ngaykt;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
        // Bao cao so tien gui
        public static DataTable SoTienGui( string matk, DateTime ngaybd, DateTime ngaykt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_SoTienGui", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@matk", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@ngaybd", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@ngaykt", SqlDbType.DateTime));
            cmd.Parameters["@matk"].Value = matk;
            cmd.Parameters["@ngaybd"].Value = ngaybd;
            cmd.Parameters["@ngaykt"].Value = ngaykt;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

          
        }

        // BACKUP CSDL
        public static void backup(string duongdan)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_BackUpCSDL", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@duongdan", SqlDbType.VarChar, 200));
            cmd.Parameters["@duongdan"].Value = duongdan;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // RESTORE CSDL
        public static void restore(string duongdan)
        {
            SqlConnection cnn = new SqlConnection("Server =AILIEN-VAIO\\SQLEXPRESS; uid=ailien; pwd=anhhoang; database=master");
            SqlCommand cmd = new SqlCommand("sp_RestoreCSDL", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@duongdan", SqlDbType.VarChar, 200));
            cmd.Parameters["@duongdan"].Value = duongdan;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
