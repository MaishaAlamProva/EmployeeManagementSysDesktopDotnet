using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1.DataAccessLayer
{
    public class UserInfo
    {
        public UserInfo() { }

        public UserInfoModel GetUserByUserName(string userName)
        {
            // Define your connection string
            //string connectionString = @"(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\OneDrive\Documents\EmpManagementSystem.mdf; Integrated Security=True; Connect Timeout=30";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\OneDrive\Documents\EmpManagementSystem.mdf;Integrated Security=True;Connect Timeout=30";


            // Create an empty DataTable to store the query result
            DataTable dataTable = new DataTable();

            // Create an instance of UserInfoModel to return
            UserInfoModel userInfo = null;

            // Use the SqlConnection within a using statement to ensure proper disposal
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create the SQL query with a parameter to avoid SQL injection
                string query = "SELECT * FROM UserInfo WHERE UserName = @UserName";

                // Use SqlCommand within a using statement
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the SQL parameter and add it to the command
                    command.Parameters.AddWithValue("@UserName", userName);

                    // Execute the query using SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            // If the DataTable contains rows, populate the UserInfoModel
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0]; // Assuming the username is unique, take the first row

                // Map the data from the DataTable row to the UserInfoModel
                userInfo = new UserInfoModel
                {
                    // Assuming your UserInfoModel has properties like Id, UserName, etc.
                    UserID = Convert.ToInt32(row["UserID"]),
                    UserName = row["UserName"].ToString(),
                    //Password = row["Password"].ToString(),
                    Password = row["Password"] as string ?? string.Empty,
                    IsAdmin = Convert.ToBoolean(row["IsAdmin"].ToString())
                    // Add other fields as necessary


                };
            }

            return userInfo;
        }

        public bool CreateUserInfo(UserInfoModel user)
        {
            string connectionString = Common.connectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO UserInfo (UserName, Password, IsAdmin) " +
                                  "VALUES (@UserName, @Password, @IsAdmin)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@UserName", user.UserName);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@IsAdmin", user.IsAdmin);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            return true;
                        }

                        return false;


                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;
            }
        }


        public bool DeleteEmployeeByKey(int empKey)
        {
            string connectionString = Common.connectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "DELETE FROM Employees WHERE EmpKey = @EmpKey";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@EmpKey", empKey);

                        
                        int result = command.ExecuteNonQuery();

                        
                        if (result > 0)
                        {
                            return true;
                        }

                        
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;
            }
        }


        public bool UpdatePasswordByEmployee(UserInfoModel user)
        {
            string connectionString = Common.connectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
              /*     string query = "UPDATE UserInfo " +
               "SET Password = @Password " +
               "FROM UserInfo " +
               "INNER JOIN EmployeesInfo ON UserInfo.EmpKey = EmployeesInfo.EmpKey " +
               "WHERE UserInfo.Username = @UserName";*/

                    // string query = "UPDATE UserInfo SET Password = @Password where Username = @UserName INNER JOIN EmployeesInfo ON UserInfo.UserName =EmployeesInfo.EmpKey ";
                    string query = "UPDATE UserInfo SET Password = @Password WHERE UserName = @UserName";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@UserName", user.UserName);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;
            }

        }



    }
}
