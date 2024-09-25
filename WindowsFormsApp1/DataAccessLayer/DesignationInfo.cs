using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.DBModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1.DataAccessLayer
{
    public class DesignationInfo
    {
        public DesignationInfo() { }

        public DesignationInfoModel GetUserByDesName(string DesName)
        {
            string connectionString = Common.connectionString;

            // Create an empty DataTable to store the query result
            DataTable dataTable = new DataTable();

            // Create an instance of DesignationInfoModel to return
            DesignationInfoModel desInfo = null;

            // Use the SqlConnection within a using statement to ensure proper disposal
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create the SQL query with a parameter to avoid SQL injection
                string query = "SELECT * FROM Designation WHERE DesName = @Position";

                // Use SqlCommand within a using statement
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the SQL parameter and add it to the command
                    command.Parameters.AddWithValue("@Position", DesName);

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
                desInfo = new DesignationInfoModel
                {
                    // Assuming your UserInfoModel has properties like Id, UserName, etc.
                    DesID = Convert.ToInt32(row["DesID"]),
                    DesName = row["DesName"].ToString(),
                    Salary = Convert.ToDouble(Convert.ToDecimal(row["Salary"])),

                    // Add other fields as necessary
                };
            }

            return desInfo;
           
        }

        public List<DesignationInfoModel> GetAllDesignation()
        {

            string connectionString = Common.connectionString;

            // Create an empty DataTable to store the query result
            DataTable dataTable = new DataTable();

            // Create an instance of UserInfoModel to return
            List< DesignationInfoModel> desInfoList = new List<DesignationInfoModel>();

            // Use the SqlConnection within a using statement to ensure proper disposal
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create the SQL query with a parameter to avoid SQL injection
                string query = "SELECT * FROM Designation";

                // Use SqlCommand within a using statement
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the SQL parameter and add it to the command
                    //command.Parameters.AddWithValue("@Position", DesName);

                    // Execute the query using SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Map the data from the DataTable row to the UserInfoModel
                    DesignationInfoModel desInfo = new DesignationInfoModel
                    {
                        DesID = Convert.ToInt32(row["DesID"]),
                        DesName = row["DesName"].ToString(),
                        Salary = Convert.ToDouble(Convert.ToDecimal(row["Salary"]))
                        // Add other fields as necessary
                    };

                    // Add the mapped object to the list
                    desInfoList.Add(desInfo);
                }
            }

            return desInfoList;

        }

        public DesignationInfoModel GetDesignationByDesID(string desID)
        {
            string connectionString = Common.connectionString;

            // Create an empty DataTable to store the query result
            DataTable dataTable = new DataTable();

            // Create an instance of DesignationInfoModel to return
            DesignationInfoModel desInfo = null;

            // Use the SqlConnection within a using statement to ensure proper disposal
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create the SQL query with a parameter to avoid SQL injection
                string query = "SELECT * FROM Designation WHERE DesID = @DesID";

                // Use SqlCommand within a using statement
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Define the SQL parameter and add it to the command
                    command.Parameters.AddWithValue("@DesID", desID);

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
                desInfo = new DesignationInfoModel
                {
                    // Assuming your UserInfoModel has properties like Id, UserName, etc.
                    DesID = Convert.ToInt32(row["DesID"]),
                    DesName = row["DesName"].ToString(),
                    Salary = Convert.ToDouble(Convert.ToDecimal(row["Salary"])),

                    // Add other fields as necessary
                };
            }

            return desInfo;
        }
    }
    
}
