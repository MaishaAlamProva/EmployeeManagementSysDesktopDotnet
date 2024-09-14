using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Models.ViewModel;

namespace WindowsFormsApp1.BusinessLayer
{
    public class AuthenticationLayer
    {
        UserInfo userInfo = new UserInfo();
        public AuthenticationLayer() {
        }

        public bool LoginAuthentication(LoginViewModel model)
        {
            var user = userInfo.GetUserByUserName(model.UserName);

            if (user != null) { 
                return String.Equals(user.Password, model.Password) ? true : false;
            }

            return false;
        }
    }
}
