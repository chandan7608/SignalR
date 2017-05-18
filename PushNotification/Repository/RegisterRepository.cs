using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PushNotification.Repository
{
    public class RegisterRepository
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dreader;
        string connstring = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        public void SaveRegistration(string username,string password)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            comm = new SqlCommand("INSERT INTO UserMaster values('" + username + "','" + password + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')", conn);
            try
            {
                comm.ExecuteNonQuery();              
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}