using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace DAL
{
    public class DBManager
    {
        SqlConnection sqlcn;
        SqlCommand sqlcmd;
        SqlDataAdapter sqlDA;
        DataTable dt;

        public DBManager()
        {
            try
            {
                sqlcn = new SqlConnection();
                sqlcn.ConnectionString = ConfigurationManager.ConnectionStrings["pubsCN"].ConnectionString;
                sqlcmd = new SqlCommand(string.Empty, sqlcn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlDA = new(sqlcmd);
                dt = new DataTable();
            }
            catch
            {
            }
        }
        public int ExecuteNonQuery(string SPName, Dictionary<string, object> Parameters)
        {
            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = SPName;
                sqlcmd.CommandType = CommandType.StoredProcedure; // ADD THIS

                foreach (var param in Parameters)
                    sqlcmd.Parameters.Add(new SqlParameter(param.Key, param.Value));

                if (sqlcn.State != ConnectionState.Open)
                    sqlcn.Open();

                return sqlcmd.ExecuteNonQuery();
            }
            finally
            {
                sqlcn.Close();
            }
            return -1;
        }
        public int ExecuteNonQuery(string SPName)
        {
            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = SPName;

                if (sqlcn.State != ConnectionState.Open)
                    sqlcn.Open();

                return sqlcmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                sqlcn.Close();
            }
            return -1;
        }
        public object ExecuteScalar(string SPName)
        {
            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = SPName;
                sqlcmd.CommandType = CommandType.StoredProcedure; // ADD THIS

                if (sqlcn.State != ConnectionState.Open)
                    sqlcn.Open();

                return sqlcmd.ExecuteScalar();
            }
            catch
            {

            }
            finally
            {
                sqlcn.Close();
            }
            return new();
        }
        public object ExecuteScalar(string SPName, Dictionary<string, object> Parameters)
        {
            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = SPName;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                foreach (var param in Parameters)
                    sqlcmd.Parameters.Add(new SqlParameter(param.Key, param.Value));

                if (sqlcn.State != ConnectionState.Open)
                    sqlcn.Open();

                return sqlcmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message); 
                return null;
            }
            finally
            {
                sqlcn.Close();
            }
        }
        public DataTable ExecuteDataTable(string SPName)
        {
            try
            {
                dt.Clear();
                sqlcmd.Parameters.Clear();

                sqlcmd.CommandText = SPName;

                sqlDA.Fill(dt);

            }
            catch
            {

            }
            return dt;
        }
        public DataTable ExecuteDataTable(string SPName, Dictionary<string, object> Parameters)
        {
            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = SPName;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                foreach (var param in Parameters)
                    sqlcmd.Parameters.Add(new SqlParameter(param.Key, param.Value));

                dt.Clear();
                sqlcmd.Parameters.Clear();

                sqlDA.Fill(dt);

            }
            catch
            {

            }
            return dt;
        }


    }
}
