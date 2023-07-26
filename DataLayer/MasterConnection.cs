using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace UsersAdmin.DataLayer
{
    public static class MasterConnection
    {
        public static SqlConnection connection = new SqlConnection("Data source=LAPTOP-JGK26CKK; Initial Catalog=DB_USERS; Integrated Security=true");

        public static void Open()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                throw ex;
            }
        }

        public static void Close()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                throw ex;
            }
        }
    }
}
