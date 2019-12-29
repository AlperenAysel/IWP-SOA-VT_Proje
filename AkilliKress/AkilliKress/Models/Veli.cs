using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkilliKress.Models
{
    public class Veli
    {
        public int VeliNo { get; set; }
        public string VeliAdi { get; set; }
        public string VeliSoyadi { get; set; }
        public string VeliKullaniciAdi { get; set; }
        public string VeliSifre { get; set; }
        public int OgrenciNot { get; set; }
        public string VeliTcNo { get; set; }
    }
}