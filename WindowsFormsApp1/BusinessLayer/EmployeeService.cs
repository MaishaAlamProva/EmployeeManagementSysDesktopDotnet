using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1.BusinessLayer
{
    public class EmployeeService
    {
        private EmployeeInfo employeeInfoDBService = new EmployeeInfo();
        private DesignationInfo designation = new DesignationInfo();  
        public EmployeeService() { }

        public bool CreateEmployee(EmployeesInfoModel employee)
        {
            if (employee != null) { 
                
                var status = employeeInfoDBService.CreateEmployee(employee);
                return status;
            }
            return false;
        }
        
        public bool DeleteEmployee(int empKey)
        {
            if (empKey > 0)
            {
                // Call the database service to delete the employee by their unique key
                var status = employeeInfoDBService.DeleteEmployeeByKey(empKey);
                return status;
            }
            return false;
        }

        public EmployeesInfoModel GetEmployeeByEmployeeKey(string  empKey)
        {
            if (!string.IsNullOrEmpty(empKey)) { 
                var data = employeeInfoDBService.GetEmployeeByEmployeeKey(empKey);

                return data;
            }
            return null;
        }
        /* public bool UpdateEmployee(EmployeesInfoModel employee)
         {
             string connectionString = Common.connectionString;
             try
             {
                 using (SqlConnection connection = new SqlConnection(connectionString))
                 {
                     connection.Open();
                     string query = "UPDATE EmployeesInfo SET EmpName = @EmpName, DesID = @DesID, Gender = @Gender, " +
                                    "PhoneNo = @PhoneNo, Email = @Email WHERE EmpKey = @EmpKey";

                     using (SqlCommand command = new SqlCommand(query, connection))
                     {
                         command.Parameters.AddWithValue("@EmpName", employee.EmpName);
                         command.Parameters.AddWithValue("@DesID", employee.DesID);
                         command.Parameters.AddWithValue("@Gender", employee.Gender);
                         command.Parameters.AddWithValue("@PhoneNo", employee.PhoneNo);
                         command.Parameters.AddWithValue("@Email", employee.Email);
                         command.Parameters.AddWithValue("@EmpKey", employee.EmpKey);

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
         }*/


        public bool UpdateEmployee(EmployeesInfoModel employee)
        {
            string connectionString = Common.connectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Step 1: Retrieve the current PhoneNo and Email from the database
                    string selectQuery = "SELECT PhoneNo, Email FROM EmployeesInfo WHERE EmpKey = @EmpKey";
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@EmpKey", employee.EmpKey);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string currentPhoneNo = reader["PhoneNo"].ToString();
                                string currentEmail = reader["Email"].ToString();

                                // Step 2: Compare the provided PhoneNo and Email with the current values
                                //if (currentPhoneNo != employee.PhoneNo || currentEmail != employee.Email)
                                //{
                                //    // Step 3: Show a message box if PhoneNo or Email are being updated
                                //    System.Windows.Forms.MessageBox.Show("You cannot update Phone Number or Email.", "Update Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                                //    return false;
                                //}
                            }
                        }
                    }

                    // Proceed with the update if PhoneNo and Email are unchanged
                    string query = "UPDATE EmployeesInfo SET EmpName = @EmpName, DesID = @DesID, Gender = @Gender WHERE EmpKey = @EmpKey";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpName", employee.EmpName);
                        command.Parameters.AddWithValue("@DesID", employee.DesID);
                        command.Parameters.AddWithValue("@Gender", employee.Gender);
                        command.Parameters.AddWithValue("@EmpKey", employee.EmpKey);

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


        public bool UpdateEmployeeByEmployee(EmployeesInfoModel employee)
        {

            if (employee != null)
            {

                var status = employeeInfoDBService.UpdateEmployeeByEmployee(employee);
                return status;
            }
            return false;

          
        }

       
        public bool SearchEmployee(int empKey)
        {
            if (empKey > 0)
            {
                var data = employeeInfoDBService.GetEmployeeByEmployeeKey(empKey.ToString());
                return (data != null) ? true : false ;
            }
            return false;
        }

        public int TotalEmployeeCount()
        {
            // Call the database service's GetTotalEmployeeCount method
            return employeeInfoDBService.GetTotalEmployeeCount();
        }

        public int GetActiveEmployee()
        {
            int activeEmpInfoCount = employeeInfoDBService.GetActiveEmployeeCount();

            // Check if no active employees are found
            if (activeEmpInfoCount == 0)
            {
                return 0; 
            }

            // Return the count of active employees
            return activeEmpInfoCount;
        }


        public int GetInActiveEmployee()
        {
            int inactiveEmpInfoCount = employeeInfoDBService.GetInActiveEmployeeCount();

            // Check if no active employees are found
            if (inactiveEmpInfoCount == 0)
            {
                // If no employees are found, you can return 0 or handle it as needed
                // This is optional; you could log a message or take other actions if necessary
                return 0; // Simply returning 0 if there are no active employees
            }

            // Return the count of active employees
            return inactiveEmpInfoCount;
        }


        public DesignationInfoModel GetSalaryByDesID(int desid)
        {
            if (desid > 0)
            {
                var data = designation.GetDesignationByDesID(desID: desid.ToString());
                return data;
            }

            return null;
        }
    }
}
