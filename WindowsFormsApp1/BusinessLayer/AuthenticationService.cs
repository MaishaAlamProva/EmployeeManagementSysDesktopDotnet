using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccessLayer;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Models.DBModel;
using WindowsFormsApp1.Models.ViewModel;

namespace WindowsFormsApp1.BusinessLayer
{
    public class AuthenticationService
    {
        UserInfo userInfo = new UserInfo();
        public AuthenticationService() { }

        public bool LoginAdminAuthentication(LoginViewModel model)
         {
            var user = userInfo.GetUserByUserName(model.UserName);

            /*if (user != null) { 
                return String.Equals(user.Password, model.Password) ? true : false;
            }
            */
            if (user != null && String.Equals(user.Password, model.Password) &&  user.IsAdmin)
            { 
                return true; 
            }
            else 
            { 
                return false; 
            }
           
           
        }

        public bool LoginEmployeeAuthentication(LoginViewModel model)
        {
            var user = userInfo.GetUserByUserName(model.UserName);

            /*if (user != null) { 
                return String.Equals(user.Password, model.Password) ? true : false;
            }
            */
            if (user != null && String.Equals(user.Password, model.Password) && !user.IsAdmin)
            {
                return true;
            }
            else
            {
                return false;
            }


        }



        public bool RegisterEmployee(LoginViewModel model)
        {
            
            UserInfoModel user = new UserInfoModel();
            user.UserName = model.UserName;
            user.Password = model.Password;
            user.IsAdmin = false;
            bool result = userInfo.CreateUserInfo(user);
            return result;
        }

    }
}
