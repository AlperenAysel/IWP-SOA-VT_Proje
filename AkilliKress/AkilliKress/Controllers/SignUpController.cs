using AkilliKress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace AkilliKress.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public ActionResult SignUp(Kullanici kullanici)
        {
            string ad = kullanici.Ad;
            string soyad = kullanici.Soyad;
            string user = kullanici.KullaniciAdi;
            string tcNo = kullanici.TcNo;
            string sifre = kullanici.Sifre;
            SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection("Server=."+"\\"+ "SQLEXPRESS;Database=AkilliKres;Trusted_Connection=True;"); 
            if (kullanici.KullaniciTuru=="Ö")
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Ogretmen(OgretmenAdi,OgretmenSoyadi,OgretmenKullaniciAdi,OgretmenSifre,OgretmenTCNo) values ('" + ad + "', '" + soyad + "', '" + user + "', '" + sifre + "','"+tcNo+ "')";
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("Kayıt tamamlandı!");
            }
            else if (kullanici.KullaniciTuru == "V")
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Veli(VeliAdi,VeliSoyadi,VeliKullaniciAdi,VeliSifre,VeliTCNo) values ('" + ad + "', '" + soyad + "', '" + user + "', '" + sifre + "','" + tcNo + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("Kayıt tamamlandı!");
            }

            return View();
        }
    }
}