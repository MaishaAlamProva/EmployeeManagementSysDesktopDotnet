using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models.DBModel;

namespace WindowsFormsApp1.BusinessLayer
{
    /* public class SalaryService
     {
         public decimal CalculateSalary(int workingDays, int absentDays, decimal baseSalary)
         {
              decimal additionalSalary = 0;


              if (workingDays >= 26 && absentDays <= 4)
              {
                  additionalSalary = 2000;
              }
              else if (workingDays > 22 && workingDays < 26 && absentDays <= 7 && absentDays >4)
              {
                  additionalSalary += 1000;
              }
              else if (workingDays <= 22 && absentDays > 7)
              {
                  additionalSalary -= 500;
              }
              if (workingDays > 31|| workingDays < 0 || absentDays > 31 || absentDays <0 )
              {

                  //Console.WriteLine("Error: Working days or absent days cannot exceed 31 an 0.");
                  System.Windows.MessageBox.Show("Invalid  Working days or absent days.");

              }



              return baseSalary + additionalSalary;

         }
     }*/


    public class SalaryService
    {
        public decimal CalculateSalary(int workingDays, int absentDays, EmployeesInfoModel employee)
        {
            
            SalaryInfo salaryInfo = new SalaryInfo();

            decimal baseSalary = salaryInfo.AddSalary(employee, workingDays, absentDays);
            return baseSalary;
        }
    }

}
