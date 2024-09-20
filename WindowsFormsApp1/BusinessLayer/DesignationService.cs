using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models.DBModel;

namespace WindowsFormsApp1.BusinessLayer
{
    public class DesignationService
    {
        private DesignationInfo designation = new DesignationInfo();
        public DesignationService() { }

        public List<DesignationInfoModel> GetAllDesignation()
        {
            return designation.GetAllDesignation();
        }
    }
}
