using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkilliKress.Models.Giris
{
    public class VeliLoginControl : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Current.Session["VeliID"].ToString()))
                {
                    base.OnActionExecuting(filterContext);
                }
                else
                    HttpContext.Current.Response.Redirect("/Login/Login");
            }
            catch (Exception)
            {
                HttpContext.Current.Response.Redirect("/Login/Login");
            }
        }
    }
}