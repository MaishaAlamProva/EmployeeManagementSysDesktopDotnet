using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.DBModel
{
    public class EmployeesInfoModel
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpKey { get; set; }
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public DateTime JoinedDate { get; set; }
        public int DesID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDisabled { get; set; }
        public string Password { get; set; }
        public int WorkingDays { get; set; }
        public int AbsentDays { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
