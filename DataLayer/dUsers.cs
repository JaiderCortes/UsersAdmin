using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UsersAdmin.LogicLayer;
using System.Windows.Forms;
using System.Data;

namespace UsersAdmin.DataLayer
{
    public class dUsers
    {
        private SqlCommand cmd = new SqlCommand();
        private int UserId;

        public bool InsertUser(lUsers dt)
        {
            try
            {
                MasterConnection.Open();
                cmd = new SqlCommand("SP_InsertUser", MasterConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", dt.UserName);
                cmd.Parameters.AddWithValue("@Password", dt.Password);
                cmd.Parameters.AddWithValue("@Icon", dt.Icon);
                cmd.Parameters.AddWithValue("@Status", dt.Status);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                return false;
            }
            finally
            {
                MasterConnection.Close();
            }
        }
    }
}
