using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev
{
    public class Evrak
    {
        int Evrak_id;
        public int Evrak_Id { get => Evrak_id; set => Evrak_id = value; }
        public string Evrak_adi { get => Evrak_adi; set => Evrak_adi = value; }
        public string Evrak_turu { get => Evrak_turu; set => Evrak_turu = value; }
        public string Aciklama { get => Aciklama; set => Aciklama = value; }
        public int Tarih { get => Tarih; set => Tarih = value; }
        public string Raf_no { get => Raf_no; set => Raf_no = value; }

        public Evrak(int gId, string gAd, string gTur, string gAciklama, int gTarih, string gRaf)
        {
            this.Evrak_id = gId;
            this.Evrak_adi= gAd;
            this.Evrak_turu= gTur;
            this.Aciklama= gAciklama;
            this.Tarih= gTarih;
            this.Raf_no = gRaf;

        }
       
         
         
           
         
        

    }
}
