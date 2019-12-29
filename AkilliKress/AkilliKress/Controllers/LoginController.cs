using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using AkilliKress.Models;
using System.Web.Security;

namespace AkilliKress.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login(Kullanici kullanici)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            string user = kullanici.KullaniciAdi;
            string sifre = kullanici.Sifre;
            con = new SqlConnection("Server=." + "\\" + "SQLEXPRESS;Database=AkilliKres;Trusted_Connection=True;");
            if (kullanici.KullaniciTuru == "Ö")
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Ogretmen where OgretmenKullaniciAdi='" + user + "'AND OgretmenSifre='" + sifre + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string ad = user.ToString();
                    Models.Giris.LoginState.OgrIsLogin(ad);
                    return RedirectToAction("OgretmenIndex","OgretmenSayfa");
                }
                con.Close();
                Response.Write("Yanlış şifre veya yanlış ad girdiniz!");
                return View();
            }
            if (kullanici.KullaniciTuru == "V")
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Veli where VeliKullaniciAdi='" + user + "'AND VeliSifre='" + sifre + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string ad = user.ToString();
                    Models.Giris.LoginState.VeliIsLogin(ad);
                    return RedirectToAction("VeliIndex","VeliSayfa");
                }
                con.Close();
                Response.Write("Yanlış şifre veya yanlış ad girdiniz!");
                return View();
            }
            else
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
  
       
        
    }
}