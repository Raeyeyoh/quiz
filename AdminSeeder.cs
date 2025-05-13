using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
        public class AdminSeeder {
       
            // Default admin credentials (should be changed after first login)
            private const string AdminEmail = "admin@quizsystem.com";
            private const string AdminPassword = "Temp@Admin123";
            private const string AdminName = "System Administrator";

            public void SeedSuperAdmin()
            {
                try
                {
                    using (SqlConnection con = new dbconnection().openConnection())
                    {
                        // Checking to see if admin already exists
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
                                Console.WriteLine("Super admin account created successfully");
                                Console.WriteLine($"Temporary credentials: {AdminEmail} / {AdminPassword}");
                                Console.WriteLine("IMPORTANT: Change this password immediately after first login!");
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

