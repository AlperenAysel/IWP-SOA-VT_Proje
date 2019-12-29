using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkilliKress.Models
{
    public class Ogrenci
    {
        public int OgrenciNo { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set;}
        public int OgrenciYasi { get; set; }
        public int HastalikNo { get; set; }
        public string OgrenciNot { get; set; }
        public bool OgrenciAsi { get; set; }
        public int OgretmenNo { get; set; }
        public string OgrenciTCNo { get; set; }
    }
}