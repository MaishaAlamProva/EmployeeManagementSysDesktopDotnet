using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1.DataAccessLayer
{
    public class EmployeeInfo
    {
        public EmployeeInfo() { }

        public bool CreateEmployee(EmployeesInfoModel employee)
        {
            string connectionString = Common.connectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO EmployeesInfo (EmpName, EmpKey,DesID, Gender, PhoneNo, Email, IsActive, IsDisabled, JoinedDate) " +
                                  "VALUES (@EmpName, @EmpKey, @DesID, @Gender, @PhoneNo, @Email, @IsActive, @IsDisabled, @JoinedDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@EmpName", employee.EmpName);
                        command.Parameters.AddWithValue("@EmpKey", employee.EmpKey);
                        command.Parameters.AddWithValue("@DesID", employee.DesID);
                        command.Parameters.AddWithValue("@Gender", employee.Gender);
                        command.Parameters.AddWithValue("@PhoneNo", employee.PhoneNo);
                        command.Parameters.AddWithValue("@Email", employee.Email);
                        command.Parameters.AddWithValue("@IsActive", 1);
                        command.Parameters.AddWithValue("@IsDisabled", 0);
                        command.Parameters.AddWithValue("@JoinedDate", DateTime.Now);

                        int result = command.ExecuteNonQuery();

                        if (result > 0) {
                            return true;
                        }

                        return false;


                    }


                }
            }
            catch (Exception ex) {
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

                    // SQL query to delete the employee by EmpKey
                    string query = "DELETE FROM EmployeesInfo WHERE EmpKey = @EmpKey";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the EmpKey parameter to the SQL command
                        command.Parameters.AddWithValue("@EmpKey", empKey);

                        // Execute the DELETE query
                        int result = command.ExecuteNonQuery();

                        // Return true if the delete operation affected at least one row
                        if (result > 0)
                        {
                            return true;
                        }

                        // Return false if no rows were deleted (EmpKey might not exist)
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


        //public EmployeesInfoModel GetUserByEmpName(string EmployeeKey)
        //{
        //    string connectionString = Common.connectionString;

        //    // Create an empty DataTable to store the query result
        //    DataTable dataTable = new DataTable();

        //    // Create an instance of DesignationInfoModel to return
        //    EmployeesInfoModel empInfo = null;

        //    // Use the SqlConnection within a using statement to ensure proper disposal
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        // Create the SQL query with a parameter to avoid SQL injection
        //        string query = "SELECT * FROM EmployeesInfo WHERE EmpKey = @EmpKey";

        //        // Use SqlCommand within a using statement
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            // Define the SQL parameter and add it to the command
        //            command.Parameters.AddWithValue("@EmpKey", EmployeeKey);

        //            // Execute the query using SqlDataAdapter to fill the DataTable
        //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //            {
        //                adapter.Fill(dataTable);
        //            }
        //        }
        //    }
        //    // If the DataTable contains rows, populate the EmpInfoModel
        //    if (dataTable.Rows.Count > 0)
        //    {
        //        DataRow row = dataTable.Rows[0]; // Assuming the username is unique, take the first row

        //        // Map the data from the DataTable row to the UserInfoModel
        //        empInfo = new EmployeesInfoModel
        //        {
        //            // Assuming your UserInfoModel has properties like Id, UserName, etc.
        //            EmpName = row["EmpName"].ToString(),
        //            EmpID = Convert.ToInt32(row["EmpID"]),
        //            //EmpKey = row["EmpKey"].ToString(),
        //            Gender = row["Gender"].ToString(),
        //            PhoneNo = row["PhoneNo"].ToString(),
        //            Email = row["Email"].ToString(),
        //            IsActive = Convert.ToBoolean(row["IsActive"].ToString()),
        //            JoinedDate = row["JoinedDate"].ToString(),
        //            DesID = Convert.ToInt32(row["DesID"]),
        //            IsDisabled = Convert.ToBoolean(row["IsDisabled"].ToString())


        //            // Add other fields as necessary
        //        };
        //    }

        //    return empInfo;

        //}

    }
}
