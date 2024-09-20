using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BusinessLayer;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1.DataAccessLayer
{
    /* public class SalaryInfo
     {
         public SalaryInfo() { }

         public decimal AddSalary(EmployeesInfoModel employee)
         {
             string connectionString = Common.connectionString;
             try
             {
                 using (SqlConnection connection = new SqlConnection(connectionString))
                 {
                     connection.Open();


                     string query = "SELECT DesId FROM EmployeesInfo WHERE EmpKey = @EmpKey";
                     int desId;
                     using (SqlCommand command = new SqlCommand(query, connection))
                     {
                         command.Parameters.AddWithValue("@EmpKey", employee.EmpKey);
                         desId = (int)command.ExecuteScalar();
                     }


                     string query2 = "SELECT Salary FROM designation WHERE DesId = @DesId";
                     decimal salary;
                     using (SqlCommand command2 = new SqlCommand(query2, connection))
                     {
                         command2.Parameters.AddWithValue("@DesId", desId);
                         salary = (decimal)command2.ExecuteScalar();
                     }


                     SalaryService salaryService = new SalaryService();
                     decimal finalSalary = salaryService.CalculateSalary(30, 0, salary); 


                     Console.WriteLine($"Final Salary: {finalSalary}");
                     //return true;
                     return finalSalary;




                 }
             }
             catch (Exception ex)
             {

                 Console.WriteLine($"An error occurred: {ex.Message}");
                 // return false;
                 throw;
             }
         }
     }*/


    public class SalaryInfo
    {
        public SalaryInfo() { }

        public decimal AddSalary(EmployeesInfoModel employee, int workingDays, int absentDays)
        {
            string connectionString = Common.connectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get DesId
                    string query = "SELECT DesId FROM EmployeesInfo WHERE EmpKey = @EmpKey";
                    int desId;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpKey", employee.EmpKey);
                        desId = (int)command.ExecuteScalar();
                    }

                    // Query to get the base Salary
                    string query2 = "SELECT Salary FROM designation WHERE DesId = @DesId";
                    decimal baseSalary;
                    using (SqlCommand command2 = new SqlCommand(query2, connection))
                    {
                        command2.Parameters.AddWithValue("@DesId", desId);
                        baseSalary = (decimal)command2.ExecuteScalar();
                    }

                    
                    decimal additionalSalary = 0;

                    if (workingDays >= 26 && absentDays <= 4)
                    {
                        additionalSalary += 2000;
                    }
                    else if ((workingDays < 26 && workingDays >= 23) && (absentDays <= 7 && absentDays > 4))
                    {
                        additionalSalary += 1000;
                    }
                    else if (workingDays <= 22 && absentDays > 7)
                    {
                        additionalSalary -= 500;
                    }


                    else if ((workingDays <= 0 || workingDays > 31) || (absentDays <= 0 || absentDays > 31))
                    {
                        // Condition 4: Invalid values for working days or active days
                        System.Windows.MessageBox.Show("Invalid input: working days or active days are out of range.");
                    }


                    decimal finalSalary = baseSalary + additionalSalary;

                    
                    Console.WriteLine($"Final Salary: {finalSalary}");

                    
                    return finalSalary;
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
    }







}



