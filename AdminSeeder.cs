using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
        public class AdminSeeder {
       
            private const string AdminEmail = "admin@quizsystem.com";
            private const string AdminPassword = "Admin123";
            private const string AdminName = "Admin";

            public void SeedSuperAdmin()
            {
                try
                {
                    using (SqlConnection con = new dbconnection().openConnection())
                    {
                        if (AdminExists(con, AdminEmail))
                        {
                            
                            return;
                        }

                        
                        string sql = @"INSERT INTO Admin (name, email, password) VALUES  (@name, @email, @password)";

                    
                     

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@name", AdminName);
                            cmd.Parameters.AddWithValue("@email", AdminEmail);
                            cmd.Parameters.AddWithValue("@password", AdminPassword);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                            MessageBox.Show($" credentials:\n" + $"name: {AdminName}\n" + $"Password: {AdminPassword}\n\n" +
                                          MessageBoxButtons.OK);

          
                            }
                    
                        }
                    
                       
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding admin: {ex.Message}");
                 
                }
            }

            private bool AdminExists(SqlConnection con, string email)
            {
                string sql = "SELECT COUNT(*) FROM Admin WHERE email = @email";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }

           
        }
 }

