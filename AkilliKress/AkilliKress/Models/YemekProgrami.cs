using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkilliKress.Models
{
    public class YemekProgrami
    {
        public int YemekNo { get; set; }
        public int IcecekNo { get; set; }
        public int MeyveNo { get; set; }
        public DateTime Tarih { get; set; }
    }
}