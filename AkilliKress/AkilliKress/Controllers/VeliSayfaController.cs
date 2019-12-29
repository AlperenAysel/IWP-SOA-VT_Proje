using AkilliKress.Models;
using AkilliKress.Models.Giris;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;

namespace AkilliKress.Controllers
{
    public class VeliSayfaController : Controller
    {  

        [VeliLoginControl]
        public ActionResult VeliIndex()
        {
            return View();
        }
        public ActionResult VeliEtkinlik()
        {
            SqlConnection con;
            SqlCommand cmd;
            con=new SqlConnection("Server=." + "\\" + "SQLEXPRESS;Database=AkilliKres;Trusted_Connection=True;");

            
            string sql = "SELECT EtkinlikNo,EtkinlikAdi,EtkinlikAciklama,OgretmenAdi FROM EtkinlikProgrami";
                cmd = new SqlCommand(sql, con);
                var model = new List<EtkinlikProgrami>();
            using (con)
            {
                con.Open();
                 SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {   
                    EtkinlikProgrami etkinlik = new EtkinlikProgrami();
                    etkinlik.EtkinlikNo = Convert.ToInt32(dr[0]);
                    etkinlik.EtkinlikAdi = dr[1].ToString();
                    etkinlik.EtkinlikAciklama = dr[2].ToString();
                    etkinlik.OgretmenAdi = dr[3].ToString();
                    model.Add(etkinlik);
                }
                con.Close();
            }
            
            return View(model);
        }
        
        public ActionResult YemekListesi()
        {
            SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection("Server=." + "\\" + "SQLEXPRESS;Database=AkilliKres;Trusted_Connection=True;");


            string sql = "SELECT Y.YemekAdi,I.IcecekAdi,M.MeyveAdi,P.Tarih FROM YemekProgrami P INNER JOIN Yemek Y ON P.YemekNo = Y.YemekNo INNER JOIN Meyve M ON P.MeyveNo = M.MeyveNo INNER JOIN Icecek I ON I.IcecekNo = P.IcecekNo";
            cmd = new SqlCommand(sql, con);
            var model = new List<YemekProgrami>();
            using (con)
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    YemekProgrami yemek = new YemekProgrami();
                    yemek.YemekNo = Convert.ToInt32(dr[0]);
                    yemek.MeyveNo= Convert.ToInt32(dr[1]);
                    yemek.IcecekNo = Convert.ToInt32(dr[2]);
                    yemek.Tarih = Convert.ToDateTime(dr[3]);
                    model.Add(yemek);
                }
                con.Close();
            }

            return View(model);

        }

        public ActionResult CanliYayin()
        {
            return View();
        }
    }
}