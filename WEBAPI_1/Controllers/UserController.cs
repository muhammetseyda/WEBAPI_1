using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace WEBAPI_1.Controllers
{
   

    public class UserController : ApiController
    {
        string Name = "Songul";
        int Password = 123;
        private object datalist1;

        public bool GetUserInfo(string userName, int userPassword)
      {
           if(userName==Name && userPassword== Password)
           {
                return true;
           }
            else
            {
                return false;
            }
                
      }

        

        public string GetKullaniciAd()
        {
             
        }
    }
}
