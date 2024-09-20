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
        EmployeeInfo employeeInfoDBService = new EmployeeInfo();
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


        public bool UpdateEmployee(EmployeesInfoModel employee)
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
        }


    }
}
