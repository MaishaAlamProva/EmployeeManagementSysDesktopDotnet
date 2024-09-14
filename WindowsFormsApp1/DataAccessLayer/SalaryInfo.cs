using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.DBModel;

namespace WindowsFormsApp1.DataAccessLayer
{
    public class SalaryInfo
    {
        public SalaryInfo() { }

        //public SalaryInfoModel GetUserByUserName(string userName)
        //{
        //    // Define your connection string
        //    //string connectionString = @"(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\OneDrive\Documents\EmpManagementSystem.mdf; Integrated Security=True; Connect Timeout=30";
        //    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\OneDrive\Documents\EmpManagementSystem.mdf;Integrated Security=True;Connect Timeout=30";


        //    // Create an empty DataTable to store the query result
        //    DataTable dataTable = new DataTable();

        //    // Create an instance of UserInfoModel to return
        //    SalaryInfoModel salaryInfo = null;

        //    // Use the SqlConnection within a using statement to ensure proper disposal
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        // Create the SQL query with a parameter to avoid SQL injection
        //        string query = "SELECT * FROM SalaryInfo WHERE SalID = @int";

        //        // Use SqlCommand within a using statement
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            // Define the SQL parameter and add it to the command
        //            command.Parameters.AddWithValue("@UserName", userName);

        //            // Execute the query using SqlDataAdapter to fill the DataTable
        //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //            {
        //                adapter.Fill(dataTable);
        //            }
        //        }
        //    }

        //    // If the DataTable contains rows, populate the UserInfoModel
        //    if (dataTable.Rows.Count > 0)
        //    {
        //        DataRow row = dataTable.Rows[0]; // Assuming the username is unique, take the first row

        //        // Map the data from the DataTable row to the UserInfoModel
        //        userInfo = new UserInfoModel
        //        {
        //            // Assuming your UserInfoModel has properties like Id, UserName, etc.
        //            UserID = Convert.ToInt32(row["UserID"]),
        //            UserName = row["UserName"].ToString(),
        //            Password = row["Password"].ToString(),
        //            IsAdmin = Convert.ToBoolean(row["IsAdmin"].ToString())
        //            // Add other fields as necessary
        //        };
        //    }

        //    return userInfo;
        //}
    }
}
