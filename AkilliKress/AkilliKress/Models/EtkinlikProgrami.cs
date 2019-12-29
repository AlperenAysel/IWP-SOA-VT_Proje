using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AkilliKress.Models
{
    public class EtkinlikProgrami
    {
        public int EtkinlikNo { get; set; }

        [DisplayName("Etkinlik Adı:")]
        public string EtkinlikAdi { get; set; }

        [DisplayName("Etkinlik Açıklaması:")]
        public string EtkinlikAciklama { get; set; }

        [DisplayName("Görevli Öğretmen")]
        public string OgretmenAdi { get; set; }
    }
}