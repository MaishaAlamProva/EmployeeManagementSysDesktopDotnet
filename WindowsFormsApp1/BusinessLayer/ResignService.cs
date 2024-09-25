using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models.DBModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.BusinessLayer
{
    public class ResignService
    {
        ResignInfo resignInfoDBService = new ResignInfo();
        public ResignService() { }
  
        //public ResignInfo ResignInfoDBService { get => resignInfoDBService; set => resignInfoDBService = value; }

        public bool CreateResign(ResignInfoModel resign, string employeeKey)
        {
            if (resign != null)
            {

                bool status = resignInfoDBService.CreateResign(resign, employeeKey);
                return status;
                
            }
            return false;
        }
    }
}
