using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    internal class dbconnection
    {
        string connectionString;
        SqlConnection connection;
        public dbconnection()
        {
        }
        public SqlConnection openConnection()
        {
            try
            {
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\raeye\\source\\repos\\quiz\\quizdb.mdf;Integrated Security=True";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception dbEx) { if (MessageBox.Show(dbEx.Message, "Database Error in DBConnection", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { Environment.Exit(0); } }
            return connection;
        }
        public void closeConnection() { connection.Close(); }
    }
}
  