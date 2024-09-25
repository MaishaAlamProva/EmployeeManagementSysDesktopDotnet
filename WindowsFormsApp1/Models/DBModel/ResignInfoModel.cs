using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.DBModel
{
    public class ResignInfoModel
    {
        public int ResID { get; set; }
        public DateTime ApplyDate { get; set; }
        public string ReasonNote { get; set; }
        public bool IsApproved { get; set; }
        public int EmpID { get; set; }
    }
}
