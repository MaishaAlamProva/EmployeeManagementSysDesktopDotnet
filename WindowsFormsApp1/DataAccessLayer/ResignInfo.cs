using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BusinessLayer;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1.DataAccessLayer
{
    public class ResignInfo
    {
        EmployeeInfo employeeInfoDBService = new EmployeeInfo();
        public ResignInfo() { }

        public bool CreateResign(ResignInfoModel resign, string employeeKey)
        {
            
        string connectionString = Common.connectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                     var dataEmployee = employeeInfoDBService.GetEmployeeByEmployeeKey(employeeKey);
               
                    if (dataEmployee == null)
                    {
                        MessageBox.Show("Employee not found.");
                    }

                    connection.Open();
                     string query = "INSERT INTO Resign (ApplyDate, ReasonNote, IsApproved,EmpID) " +
                                 "VALUES (@ApplyDate, @ReasonNote, @IsApproved,@EmpID)";

                    /*
                        string query = "INSERT INTO Resign (ApplyDate, ReasonNote, IsApproved, EmpId) " +
                   "VALUES (@ApplyDate, @ReasonNote, @IsApproved, " +
                   "(SELECT TOP 1 EmpID FROM EmployeesInfo WHERE EmpID = ANY (SELECT EmpID FROM Resign)))";*/


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //command.Parameters.AddWithValue("@ResID", resign.ResID);
                        command.Parameters.AddWithValue("@ApplyDate", DateTime.Now);
                        command.Parameters.AddWithValue("@ReasonNote", resign.ReasonNote);
                        command.Parameters.AddWithValue("@IsApproved", 1);
                        command.Parameters.AddWithValue("@EmpID",dataEmployee.EmpID);



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
                // Handle general exceptions
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }


        }
    }
}
     

