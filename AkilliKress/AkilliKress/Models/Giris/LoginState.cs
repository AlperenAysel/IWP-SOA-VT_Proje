using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using AkilliKress.Models;
using System.Web.Security;

namespace AkilliKress.Models.Giris
{
    public class LoginState
    {
        public static void OgrIsLogin(String kullanici)
        {
            HttpContext.Current.Session.Add("OgrID", kullanici);
        }
        public static void VeliIsLogin(String kullanici)
        {
            HttpContext.Current.Session.Add("VeliID", kullanici);
        }

    }
}