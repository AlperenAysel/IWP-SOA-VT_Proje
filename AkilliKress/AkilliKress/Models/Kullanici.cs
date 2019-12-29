using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AkilliKress.Models
{
    public class Kullanici
    {
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string TcNo { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string KullaniciAdi { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string Sifre { get; set; }
        [Required(ErrorMessage = "İşaretlemeniz gerekiyor.")]
        public string KullaniciTuru { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}