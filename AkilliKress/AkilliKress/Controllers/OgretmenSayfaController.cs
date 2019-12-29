using AkilliKress.Models.Giris;
using AkilliKress.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace AkilliKress.Controllers
{
    public class OgretmenSayfaController : Controller
    {
        [OgrLoginCont]
        public ActionResult OgretmenIndex()
        {
            return View();
        }
       
        [HttpGet]
        public ActionResult OgretmenEtkinlik()
        {

            DataTable dt = new DataTable();
            using(SqlConnection sqlCon=new SqlConnection("Server=." + "\\" + "SQLEXPRESS;Database=AkilliKres;Trusted_Connection=True;"))
            {
                sqlCon.Open();
                SqlDataAdapter data = new SqlDataAdapter("SELECT EtkinlikNo,EtkinlikAdi,EtkinlikAciklama,OgretmenAdi FROM EtkinlikProgrami",sqlCon);
                data.Fill(dt);
            }
           

            return View(dt);
        }
        public ActionResult OgrenciListe()
        {
            /*SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection("Server=." + "\\" + "SQLEXPRESS;Database=AkilliKres;Trusted_Connection=True;");


            string sql = "SELECT O.OgrenciNo,O.OgrenciAdi,O.OgrenciSoyadi,O.OgrenciYasi,R.OgretmenAdi FROM Ogrenci O INNER JOIN Ogretmen R ON O.OgretmenNo = R.OgretmenNo ";
            cmd = new SqlCommand(sql, con);
            var model = new List<Ogrenci>();
            using (con)
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ogrenci ogr = new Ogrenci();
                    ogr.OgrenciNo = Convert.ToInt32(dr[0]);
                    ogr.OgrenciAdi = dr[1].ToString();
                    ogr.OgrenciSoyadi = dr[2].ToString();
                    ogr.OgrenciYasi = Convert.ToInt32(dr[3]);
                    ogr.OgretmenNo = Convert.ToInt32(dr[4]);
                    ogr.HastalikNo = Convert.ToInt32(dr[5]);
                    model.Add(ogr);
                }
                con.Close();
            }

            return View(model);*/
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection("Server=." + "\\" + "SQLEXPRESS;Database=AkilliKres;Trusted_Connection=True;"))
            {
                sqlCon.Open();
                SqlDataAdapter data = new SqlDataAdapter("SELECT O.OgrenciNo,O.OgrenciAdi,O.OgrenciSoyadi,O.OgrenciYasi,R.OgretmenAdi FROM Ogrenci O INNER JOIN Ogretmen R ON O.OgretmenNo = R.OgretmenNo", sqlCon);
                data.Fill(dt);
            }


            return View(dt);
        
    }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new EtkinlikProgrami());


        }
        [HttpPost]
        public ActionResult Create(EtkinlikProgrami etkinlikButun)
        {
            using (SqlConnection sqlCon = new SqlConnection("Server=." + "\\" + "SQLEXPRESS;Database=AkilliKres;Trusted_Connection=True;"))
            {
                sqlCon.Open();
                string query = "INSERT INTO EtkinlikProgrami VALUES(@EtkinlikAdi,@EtkinlikAciklama,@OgretmenAdi)";
                SqlCommand cmd = new SqlCommand(query,sqlCon);
                cmd.Parameters.AddWithValue("@EtkinlikAdi", etkinlikButun.EtkinlikAdi);
                cmd.Parameters.AddWithValue("@EtkinlikAciklama", etkinlikButun.EtkinlikAciklama);
                cmd.Parameters.AddWithValue("@OgretmenAdi", etkinlikButun.OgretmenAdi);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("OgretmenEtkinlik");
        }
       

        public ActionResult Film(EtkinlikProgrami etkinlik)
        {
                return View();
            
        }



    }
}